using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class UnitInstaller : MonoInstaller
    {
        [SerializeField] private PlayerParametersBase playerParameters;
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private PrefabBase prefabBase;

        public override void InstallBindings()
        {
            Container.Bind<IPlayerParameters>().FromInstance(playerParameters).AsSingle();
            Container.Bind<IEnemyParameters>().FromInstance(enemyParameters).AsSingle();
            Container.Bind<IBaseParameters>().FromInstance(prefabBase).AsSingle();
        }
    }
}
