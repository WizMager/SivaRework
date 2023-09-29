using CharacterParameters.UnitsParameters;

namespace Assets.Scripts.Factory
{
    public abstract class Enemy
    {
        public EEnemyType EnemyType { get; }

        public Enemy(EEnemyType enemyType)
        {
            EnemyType = enemyType;
        }
    }
}
