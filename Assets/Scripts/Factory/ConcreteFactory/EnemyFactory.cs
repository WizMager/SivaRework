using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.Factory;
using CharacterParameters.UnitsParameters;
using Controllers.EnemyController;
using Controllers.MainController;
using Services.GameFieldProvider;
using UnityEngine;
using Views;

namespace Factory.ConcreteFactory
{
    public class EnemyFactory : AEnemyFactory
    {
        private readonly IEnemyParameters _enemyParameters;
        private readonly IPrefabBase _prefabBase;
        private readonly IMainController _mainController;
        private readonly PlayerView _playerView;

        public EnemyFactory(
            IEnemyParameters enemyParameters,
            IPrefabBase prefabBase,
            IMainController mainController,
            IGameFieldProvider gameFieldProvider
        )
        {
            _enemyParameters = enemyParameters;
            _prefabBase = prefabBase;
            _mainController = mainController;

            var playerGameObject = gameFieldProvider.GameField.Player;
            var playerView = playerGameObject.GetComponent<PlayerView>();
            _playerView = playerView;
        }

        public override void CreateEnemy(EEnemyType enemyType)
        {
            switch (enemyType)
            {
                case EEnemyType.Zombie:
                    CreateZombie();
                    break;
                case EEnemyType.Skeleton:
                    break;
                case EEnemyType.Warlock:
                    break;
            }
        }

        private void CreateZombie()
        {
            var prefab = _prefabBase.GetPrefabBase(EEnemyType.Zombie.ToString());

            var enemy = Object.Instantiate(prefab, new Vector3(0,0,5), Quaternion.identity);

            var enemyView = enemy.GetComponent<EnemyView>();

            var enemyParameters = _enemyParameters.GetParametersByType(EEnemyType.Zombie);

            var enemyController = new EnemyController(EEnemyType.Zombie, enemyParameters, enemyView, _playerView);
            _mainController.AddController(enemyController);
        }
    }
}
