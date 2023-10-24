using Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using Controllers.Interfaces;
using Views;

namespace Controllers.EnemyController
{
    public class EnemyController : IStart, IUpdate 
    {
        private readonly EnemyView _enemyView;
        private readonly SimpleAiBTree _simpleAiBTree;

        public EnemyController(EEnemyType enemyType, EnemyParameters enemyParameters, EnemyView enemyView, PlayerView playerView)
        {
            //TODO: create EnemyParametersController(or ZombieParametersController), use EnemyParameters in it
            _enemyView = enemyView;

            //TODO: push EnemyParametersController in SimpleAiBTree. BTree must not have field just have links on parameters. All parameters only in single controller
            _simpleAiBTree = new SimpleAiBTree(/*IEnemyParametersController,*/ _enemyView.transform, playerView);
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
