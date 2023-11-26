using Abilities;
using Assets.Scripts.Controllers.PlayerAttackController;
using CharacterParameters.Interfaces;
using CharacterParameters.UnitsParameters;
using Controllers.InputController.Impl;
using Controllers.MainController.Impl;
using Controllers.MoveController;
using Controllers.PlayerController;
using Factory.ConcreteFactory;
using Services.GameFieldProvider;
using Services.GameFieldProvider.Impl;
using UnityEngine;
using Utils;
using Zenject;

namespace Installers
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private GameField gameField;
        [SerializeField] private PlayerParametersBase playerParameters;
        [SerializeField] private AbilityBase abilityBase;
        [SerializeField] private AbilityButtonsView abilityButtonsView;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainController>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<InputController>().AsSingle().NonLazy();
            
            var gameFieldProvider = new GameFieldProvider(gameField);
            Container.Bind<IGameFieldProvider>().FromInstance(gameFieldProvider).AsSingle();
            Container.Bind<IPlayerParametersBase>().FromInstance(playerParameters).AsSingle();
            Container.Bind<IAbilityBase>().FromInstance(abilityBase).AsSingle();
            Container.Bind<AbilityButtonsView>().FromInstance(abilityButtonsView);

            Container.Bind<EnemyFactory>().AsSingle();
            Container.Instantiate<PlayerController>();
            Container.Instantiate<MoveController>();
            Container.Instantiate<PlayerAttackController>();
        }
    }
}