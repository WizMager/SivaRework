using Assets.Scripts.CharacterParameters.UnitsParameters;
using System.Collections.Generic;

namespace Assets.Scripts.Ai
{
    public class AiBTreeParameters
    {
        private readonly float _followSpeed; // speed
        private readonly float _maxFollowDistance;
        private readonly float _attackDistance;
        private readonly float _damage; // power
        private readonly float _attackCooldown; // dex

        public float FollowSpeed => _followSpeed;
        public float MaxFollowDistance => _maxFollowDistance;
        public float AttackDistance => _attackDistance;
        public float Damage => _damage;
        public float AttackCooldown => _attackCooldown; 

        private EParameters eParameters;
        private Parameters parameters;

        private Dictionary<EAiBTreeParameters, float> _parameters = new();

        public AiBTreeParameters(EnemyParameters enemyParameters)
        {
            foreach (var item in enemyParameters.aiBTreeParametersValues)
            {
                _parameters.Add(item.eParametersAiBTree, item.Value);
            }
        }

        public void SetAiBTreeParameters()
        {
            switch (eParameters)
            {
                case EParameters.Dexterity:
                    var attackCooldown = parameters.GetParameter(EParameters.Dexterity);
                     attackCooldown = AttackCooldown;
                    return;
                case EParameters.Power:
                    var damage = parameters.GetParameter(EParameters.Power);
                    damage = Damage;
                    return;
                case EParameters.MoveSpeed:
                    var followSpeed = parameters.GetParameter(EParameters.MoveSpeed);
                    followSpeed = FollowSpeed;
                    return;                
            }
        }
    }
}
