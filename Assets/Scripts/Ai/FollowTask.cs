using BehaviorTree;
using UnityEngine;

namespace Ai
{
    public class FollowTask : Node
    {
        private readonly float _followSpeed;
        private readonly Transform _ownerTransform;
        private readonly Transform _targetTransform;

        public FollowTask(
            Transform ownerTransform, 
            Transform targetTransform, 
            float followSpeed
        )
        {
            _ownerTransform = ownerTransform;
            _targetTransform = targetTransform;
            _followSpeed = followSpeed;
        }
        
        public override NodeState Evaluate()
        {
            _ownerTransform.position = Vector3.MoveTowards(_ownerTransform.position,
                _targetTransform.position, _followSpeed * Time.deltaTime);
            
            _ownerTransform.LookAt(_targetTransform);
            
            State = NodeState.Running;
            return State;
        }
    }
}