using Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using Controllers.Interfaces;
using Views;

namespace Controllers.EnemyController
{
    public class EnemyController : IStart, IUpdate 
    {
        private readonly EnemyParameters _enemyParameters;
        private readonly EnemyView _enemyView;
        private readonly SimpleAiBTree _simpleAiBTree;

        public EnemyController(EEnemyType enemyType, EnemyParameters enemyParameters, EnemyView enemyView, PlayerView playerView)
        {
            _enemyParameters = enemyParameters;
            _enemyView = enemyView;

            //TODO: need use enemy parameters from class and subscribe on change its. If change some params just invoke
            //action with all list of parameters but maybe will be other variant
            _simpleAiBTree = new SimpleAiBTree(2, 10, 1, 5, 1.5f, _enemyView.transform, playerView);
        }

        public void OnStart()
        {
            _simpleAiBTree.OnStart();
        }

        public void OnUpdate()
        {
            _simpleAiBTree.OnUpdate();
        }
    }
}
