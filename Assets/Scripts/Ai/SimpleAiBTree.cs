using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;
using Views;
using Tree = BehaviorTree.Tree;

namespace Ai
{
    public class SimpleAiBTree : Tree
    {
        private float _followSpeed;
        private float _maxFollowDistance;
        private float _attackDistance;
        private float _damage;
        private float _attackCooldown;
        private readonly Transform _ownerTransform;
        private readonly PlayerView _playerView;

        public SimpleAiBTree(
            float followSpeed, 
            float maxFollowDistance, 
            float attackDistance, 
            float damage, 
            float attackCooldown, 
            Transform ownerTransform, 
            PlayerView playerView
        )
        {
            _followSpeed = followSpeed;
            _maxFollowDistance = maxFollowDistance;
            _attackDistance = attackDistance;
            _damage = damage;
            _attackCooldown = attackCooldown;
            _ownerTransform = ownerTransform;
            _playerView = playerView;
        }
        
        protected override Node SetupTree()
        {
            var playerTransform = _playerView.transform;
            
            return new Selector(new List<Node>
            {
                new Sequence(new List<Node>
                {
                    new CheckFollowDistance(_ownerTransform, playerTransform, _maxFollowDistance, _attackDistance),
                    new FollowTask(_ownerTransform, playerTransform, _followSpeed)
                }),
                new Sequence(new List<Node>
                {
                    new CheckAttackDistance(_attackDistance, _ownerTransform, playerTransform),
                    new AttackTargetTask(_playerView, _damage, _attackCooldown)
                })
            });
        }
    }
}