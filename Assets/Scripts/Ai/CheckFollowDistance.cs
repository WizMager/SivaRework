using BehaviorTree;
using UnityEngine;

namespace Ai
{
    public class CheckFollowDistance : Node
    {
        private readonly float _followMaxDistance;
        private readonly float _attackDistance;
        private readonly Transform _ownerTransform;
        private readonly Transform _targetTransform;
        
        public CheckFollowDistance(
            Transform ownerTransform, 
            Transform targetTransform, 
             ref float followMaxDistance, 
             ref float attackDistance
        )
        {
            _ownerTransform = ownerTransform;
            _targetTransform = targetTransform;
            _followMaxDistance = followMaxDistance;
            _attackDistance = attackDistance;
        }
        
        public override NodeState Evaluate()
        {
            var distance = (_targetTransform.position - _ownerTransform.position).sqrMagnitude;
            
            if (distance <= _followMaxDistance * _followMaxDistance && distance > _attackDistance * _attackDistance)
            {
                Parent.Parent.SetData("RefreshAttackCooldown", true); //TODO: this is a bad thing, just for example
                
                State = NodeState.Success;
                return State;
            }
            
            State = NodeState.Failure;
            return State;            
        }
    }
}