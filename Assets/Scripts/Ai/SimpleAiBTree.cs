using System.Collections.Generic;
using BehaviorTree;
using CharacterParameters.Interfaces;
using UnityEngine;
using Views;
using Tree = BehaviorTree.Tree;

namespace Ai
{
    public class SimpleAiBTree : Tree
    {
        [SerializeField] private float followSpeed;
        [SerializeField] private float maxFollowDistance;
        [SerializeField] private float attackDistance;
        [SerializeField] private float damage;
        [SerializeField] private float attackCooldown;
        [SerializeField] private Transform ownerTransform;
        [SerializeField] private PlayerView playerView;
        
        protected override Node SetupTree()
        {
            var playerTransform = playerView.transform;
            
            return new Selector(new List<Node>
            {
                new Sequence(new List<Node>
                {
                    new CheckFollowDistance(ownerTransform, playerTransform, maxFollowDistance, attackDistance),
                    new FollowTask(ownerTransform, playerTransform, followSpeed)
                }),
                new Sequence(new List<Node>
                {
                    new CheckAttackDistance(attackDistance, ownerTransform, playerTransform),
                    new AttackTargetTask(playerView, damage, attackCooldown)
                })
            });
        }
    }
}