using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using Assets.Scripts.Controllers.EnemyController;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Factory.ConcreteFactory
{
    public class EnemyFactory : AEnemyFactory
    {
        private readonly IEnemyParameters _enemyParameters;

        public EnemyFactory(IEnemyParameters enemyParameters)
        {
            _enemyParameters = enemyParameters;
        }

        public override void CreateEnemy(EEnemyType enemyType)
        {
            switch (enemyType)
            {
                case EEnemyType.zombie:
                    CreateZombie();
                    break;
                case EEnemyType.skeleton:
                    break;
                case EEnemyType.warlock:
                    break;
            }
        }

        public void CreateZombie()
        {
            GameObject prefabPlaseholder = new(name: "TestEnemy");

            var enemy = Object.Instantiate(prefabPlaseholder, new Vector3(0,0,5), Quaternion.identity);

            var enemyView = enemy.GetComponent<EnemyView>();

            var enemyParameters = _enemyParameters.GetParametersByType(EEnemyType.zombie);

            new EnemyController(EEnemyType.zombie, enemyParameters, enemyView);
        }
    }
}
