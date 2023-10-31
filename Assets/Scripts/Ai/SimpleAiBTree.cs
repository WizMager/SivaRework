using System.Collections.Generic;
using Assets.Scripts.Ai;
using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using BehaviorTree;
using UnityEngine;
using Views;
using Tree = BehaviorTree.Tree;

namespace Ai
{
    public class SimpleAiBTree : Tree
    {
        private readonly Transform _ownerTransform;
        private readonly PlayerView _playerView;
        private readonly IEnemyParametersController _enemyParametersController;

        public SimpleAiBTree(
            IEnemyParametersController enemyParametersController,
            Transform ownerTransform, 
            PlayerView playerView
        )
        {
            _enemyParametersController = enemyParametersController;
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
                    new CheckFollowDistance(_ownerTransform, playerTransform,
                    ref _enemyParametersController.GetParametersRefAi(EAiBTreeParameters.MaxFollowDistance),
                    ref _enemyParametersController.GetParametersRefAi(EAiBTreeParameters.AttackDistance)),
                    new FollowTask(_ownerTransform, playerTransform,
                    ref _enemyParametersController.GetParametersRef(EParameters.MoveSpeed))
                }),
                new Sequence(new List<Node>
                {
                    new CheckAttackDistance(ref _enemyParametersController.GetParametersRefAi(EAiBTreeParameters.AttackDistance), _ownerTransform, playerTransform),
                    new AttackTargetTask(_playerView,
                    ref _enemyParametersController.GetParametersRef(EParameters.Power),
                    ref _enemyParametersController.GetParametersRef(EParameters.Dexterity))
                })
            });
        }
    }
}