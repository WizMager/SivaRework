using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using Views;

namespace Controllers.EnemyController
{
    public class EnemyController 
    {
        private readonly EnemyParameters _enemyParameters;
        private readonly EnemyView _enemyView;

        public EnemyController(EEnemyType enemyType, EnemyParameters enemyParameters, EnemyView enemyView)
        {
            _enemyParameters = enemyParameters;
            _enemyView = enemyView;
        }        
    }
}
