using System.Collections.Generic;
using Assets.Scripts.Ai;
using BehaviorTree;
using UnityEngine;
using Views;
using Tree = BehaviorTree.Tree;

namespace Ai
{
    public class SimpleAiBTree : Tree
    {
        private float _followSpeed; //delete this
        private float _maxFollowDistance; //delete this
        private float _attackDistance; //delete this
        private float _damage; //delete this
        private float _attackCooldown; //delete this
        private readonly Transform _ownerTransform;
        private readonly PlayerView _playerView;
        private readonly AiBTreeParameters _aiBTreeParameters;

        public SimpleAiBTree(
            //IEnemyParameters enemyParametersController,
            Transform ownerTransform, 
            PlayerView playerView
        )
        {
            //_followSpeed = _aiBTreeParameters.FollowSpeed;
            //_maxFollowDistance = _aiBTreeParameters.MaxFollowDistance;
            //_attackDistance = _aiBTreeParameters.AttackDistance;
            //_damage = _aiBTreeParameters.Damage;
            //_attackCooldown = _aiBTreeParameters.AttackCooldown;

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
                    //TODO: need link on variable or subscribe on change parameter, or just give IEnemyParametersController and take need parameter by type
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