using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Assets.Scripts.Factory
{
    public abstract class AEnemyFactory 
    {
        public abstract void CreateEnemy(EEnemyType enemyType);
    }
}
