using Assets.Scripts.Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using BehaviorTree;
using System.Collections.Generic;
using UnityEngine;
using Views;
using Tree = BehaviorTree.Tree;

namespace Ai
{
    public class SimpleAiBTree : Tree
    {
        private float _followSpeed; // miltiplied whis normal enemy speed
        private float _maxFollowDistance;
        private float _attackDistance;
        private float _damage;
        private float _attackCooldown;
        private readonly Transform _ownerTransform;
        private readonly PlayerView _playerView;
        private readonly AiBTreeParameters _aiBTreeParameters;

        public SimpleAiBTree(
            //EnemyParameters enemyParameters,
            Transform ownerTransform, 
            PlayerView playerView
        )
        {
            _followSpeed = _aiBTreeParameters.FollowSpeed;
            _maxFollowDistance = _aiBTreeParameters.MaxFollowDistance;
            _attackDistance = _aiBTreeParameters.AttackDistance;
            _damage = _aiBTreeParameters.Damage;
            _attackCooldown = _aiBTreeParameters.AttackCooldown;

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