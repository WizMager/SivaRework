using Assets.Scripts.CharacterParameters.UnitsParameters;
using Assets.Scripts.Views;

namespace Assets.Scripts.Controllers.EnemyController
{
    public class EnemyController 
    {
        private readonly EnemyParameters _enemyParameters;
        private readonly EnemyView _enemyView;

        public EnemyController(EEnemyType enemyType, EnemyParameters enemyParameters, EnemyView enemyView)
        {
            _enemyParameters = enemyParameters;
            _enemyView = enemyView;
            enemyType = enemyView.EnemyType;
        }        
    }
}
