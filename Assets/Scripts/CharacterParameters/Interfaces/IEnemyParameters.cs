using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Assets.Scripts.CharacterParameters.Interfaces
{
    public interface IEnemyParameters
    {
        public EnemyParameters GetParametersByType(EEnemyType enemyType);
    }
}
