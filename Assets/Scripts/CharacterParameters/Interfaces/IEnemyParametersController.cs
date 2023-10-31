using Assets.Scripts.Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Assets.Scripts.CharacterParameters.Interfaces
{
    public interface IEnemyParametersController
    {
        public float GetEnemyParameters(EParameters eParameters);
        public float GetEnemyParameters(EAiBTreeParameters eAiBTreeParameters);

        public ref float GetParametersRef(EParameters eParameters);
        public ref float GetParametersRefAi(EAiBTreeParameters eAiBTreeParameters);
    }
}
