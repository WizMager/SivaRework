using BehaviorTree;
using UnityEngine;

namespace Ai
{
    public class CheckAttackDistance : Node
    {
        private readonly float _attackDistance;
        private readonly Transform _owner;
        private readonly Transform _target;

        public CheckAttackDistance(
            float attackDistance, 
            Transform owner, 
            Transform target
        )
        {
            _attackDistance = attackDistance;
            _owner = owner;
            _target = target;
        }
        
        public override NodeState Evaluate()
        {
            var distance = (_target.position - _owner.position).sqrMagnitude;

            if (distance <= _attackDistance * _attackDistance)
            {
                State = NodeState.Success;
                return State;
            }
            
            State = NodeState.Failure;
            return State;
        }
    }
}