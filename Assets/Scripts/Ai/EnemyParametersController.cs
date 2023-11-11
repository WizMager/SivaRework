using System;
using Assets.Scripts.Ai;
using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using Controllers.CharacteristicsController;

namespace Ai
{
    public class EnemyParametersController : ParametersController, IEnemyParametersController
    {
        private readonly Parameters _parameters;

        public EnemyParametersController(EnemyParameters enemyParameters) : base(enemyParameters)
        {
            _parameters = new Parameters(enemyParameters);
        }

        public ref float GetParametersRef(EParameters eParameters)
        {
            return ref _parameters.GetParametersRef(eParameters);
        }

        public ref float GetParametersRefAi(EAiBTreeParameters eAiBTreeParameters)
        {
            return ref _parameters.GetParametersRefAi(eAiBTreeParameters);
        }

        public float GetEnemyParameters(EParameters eParameters)
        {
            switch (eParameters)
            {                
                case EParameters.Dexterity:
                    var attackCooldown = _parameters.GetParameter(EParameters.Dexterity);
                    return attackCooldown;
                case EParameters.Power:
                    var damage = _parameters.GetParameter(EParameters.Power);
                    return damage;
                case EParameters.MoveSpeed:
                    var followSpeed = _parameters.GetParameter(EParameters.MoveSpeed);
                    return followSpeed;
                default:
                    throw new NotImplementedException();
            }
        }

        public float GetEnemyParameters(EAiBTreeParameters eAiBTreeParameters)
        {
            switch (eAiBTreeParameters)
            {
                case EAiBTreeParameters.MaxFollowDistance:
                    var maxFollowDistance = _parameters.GetEnemyParameter(EAiBTreeParameters.MaxFollowDistance);
                    return maxFollowDistance;
                case EAiBTreeParameters.AttackDistance:
                    var attackDistance = _parameters.GetEnemyParameter(EAiBTreeParameters.AttackDistance);
                    return attackDistance;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
