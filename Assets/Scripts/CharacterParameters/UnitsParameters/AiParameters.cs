using Assets.Scripts.Ai;
using System;

namespace Assets.Scripts.CharacterParameters.UnitsParameters
{
    public class AiParameters
    {
        private float _maxFollowDistance;
        private float _attackDistance;

        public AiParameters(AiBTreeParametersValue[] enemyParameters)
        {
            foreach (var parameter in enemyParameters)
            {
                switch (parameter.eParametersAiBTree)
                {
                    case EAiBTreeParameters.MaxFollowDistance:
                        _maxFollowDistance = parameter.value;
                        break;
                    case EAiBTreeParameters.AttackDistance:
                        _attackDistance = parameter.value;
                        break;
                    case EAiBTreeParameters.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public ref float GetParametersRefAi(EAiBTreeParameters eAiBTreeParameters)
        {
            switch (eAiBTreeParameters)
            {
                case EAiBTreeParameters.MaxFollowDistance:
                    return ref _maxFollowDistance;
                case EAiBTreeParameters.AttackDistance:
                    return ref _attackDistance;
                default:
                    throw new Exception("Parameter not found");
            }
        }

        public float GetEnemyParameter(EAiBTreeParameters eAiBTreeParameters)
        {
            switch (eAiBTreeParameters)
            {
                case EAiBTreeParameters.MaxFollowDistance:
                    return _maxFollowDistance;
                case EAiBTreeParameters.AttackDistance:
                    return _attackDistance;
                default:
                    throw new Exception("Parameter not found");
            }
        }
    }
}
