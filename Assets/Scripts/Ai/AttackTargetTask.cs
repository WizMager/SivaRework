using BehaviorTree;
using CharacterParameters.Interfaces;
using UnityEngine;

namespace Ai
{
    public class AttackTargetTask : Node
    {
        private readonly IDamagable _target;
        private readonly float _damage;
        private readonly float _attackCooldown;

        private float _timeBeforeAttack;

        public AttackTargetTask(
            IDamagable target, 
            float damage, 
            float attackCooldown
        )
        {
            _target = target;
            _damage = damage;
            _attackCooldown = attackCooldown;
        }
        
        public override NodeState Evaluate()
        {
            var isFirstAttack = (bool)Parent.Parent.GetData("RefreshAttackCooldown"); //TODO: this is a bad thing, just for example
            
            if (isFirstAttack || _timeBeforeAttack <= 0)
            {
                _target.ReceiveDamage(_damage);

                _timeBeforeAttack = _attackCooldown;
                
                Parent.Parent.SetData("RefreshAttackCooldown", false);
            }
            else
            {
                _timeBeforeAttack -= Time.deltaTime;
            }
            
            State = NodeState.Running;
            return State;
        }
    }
}