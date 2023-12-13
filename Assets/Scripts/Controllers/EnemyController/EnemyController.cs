using Ai;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using Controllers.Interfaces;
using Views;

namespace Controllers.EnemyController
{
    public class EnemyController : IStart, IUpdate 
    {
        private readonly EnemyView _enemyView;
        private readonly SimpleAiBTree _simpleAiBTree;
        private readonly EnemyParametersController _enemyParametersController;

        public EnemyController(EnemyParameters enemyParameters, EnemyView enemyView, PlayerView playerView)
        {
            _enemyParametersController = new EnemyParametersController(enemyParameters);

            _enemyView = enemyView;

            _simpleAiBTree = new SimpleAiBTree(_enemyParametersController, _enemyView.transform, playerView);
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
