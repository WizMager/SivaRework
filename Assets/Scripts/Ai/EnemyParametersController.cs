using Assets.Scripts.Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using Controllers.CharacteristicsController;
using System;

namespace Ai
{
    public class EnemyParametersController : ParametersController
    {
        private readonly AiParameters _enemyParameters;

        public EnemyParametersController(EnemyParameters enemyParameters) : base(enemyParameters.parametersValue)
        {
            _enemyParameters = new AiParameters(enemyParameters.aiBTreeParametersValues);
        }

        public ref float GetParametersRefAi(EAiBTreeParameters eAiBTreeParameters)
        {
            return ref _enemyParameters.GetParametersRefAi(eAiBTreeParameters);
        }
                
        public float GetEnemyParameters(EAiBTreeParameters eAiBTreeParameters)
        {
            switch (eAiBTreeParameters)
            {
                case EAiBTreeParameters.MaxFollowDistance:
                    var maxFollowDistance = _enemyParameters.GetEnemyParameter(EAiBTreeParameters.MaxFollowDistance);
                    return maxFollowDistance;
                case EAiBTreeParameters.AttackDistance:
                    var attackDistance = _enemyParameters.GetEnemyParameter(EAiBTreeParameters.AttackDistance);
                    return attackDistance;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
