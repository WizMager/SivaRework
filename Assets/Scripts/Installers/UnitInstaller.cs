using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using CharacterParameters.UnitsParameters;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class UnitInstaller : MonoInstaller
    {
        [SerializeField] private PlayerParametersBase playerParameters;
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private PrefabBase prefabBase;

        public override void InstallBindings()
        {
            Container.Bind<IPlayerParametersBase>().FromInstance(playerParameters).AsSingle();
            Container.Bind<IEnemyParameters>().FromInstance(enemyParameters).AsSingle();
            Container.Bind<IPrefabBase>().FromInstance(prefabBase).AsSingle();
        }
    }
}
