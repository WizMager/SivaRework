using Abilities;
using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
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
        [SerializeField] private AbilityBase abilityBase;

        public override void InstallBindings()
        {
            Container.Bind<IEnemyParameters>().FromInstance(enemyParameters).AsSingle();
            Container.Bind<IPrefabBase>().FromInstance(prefabBase).AsSingle();
        }
    }
}
