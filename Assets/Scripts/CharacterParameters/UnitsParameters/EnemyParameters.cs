using CharacterParameters.UnitsParameters;
using System;

namespace Assets.Scripts.CharacterParameters.UnitsParameters
{
    [Serializable]
    public class EnemyParameters
    {
        public ParametersValue[] parametersValue;
        public AiBTreeParametersValue[] aiBTreeParametersValues;
        public EEnemyType enemyType;
    }
}
