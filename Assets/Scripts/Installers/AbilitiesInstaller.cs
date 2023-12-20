using Abilities;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class AbilitiesInstaller : MonoInstaller
    {
        [SerializeField] private ClassAbilityBase abilityBase;
        [SerializeField] private AbilityButtonsView abilityButtonsView;

        public override void InstallBindings()
        {
            Container.Bind<IAbilityBase>().FromInstance(abilityBase).AsSingle();
            Container.Bind<AbilityButtonsView>().FromInstance(abilityButtonsView).AsSingle();
        }

    }
}
