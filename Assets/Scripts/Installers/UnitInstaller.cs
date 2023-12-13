using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using Factory.ConcreteFactory;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class UnitInstaller : MonoInstaller
    {
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private PrefabBase prefabBase;

        public override void InstallBindings()
        {
            Container.Bind<IEnemyParameters>().FromInstance(enemyParameters).AsSingle();
            Container.Bind<IPrefabBase>().FromInstance(prefabBase).AsSingle();

            Container.Bind<EnemyFactory>().AsSingle();
        }
    }
}
