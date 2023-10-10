﻿using Assets.Scripts.Controllers.PlayerAttackController;
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
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainController>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<InputController>().AsSingle().NonLazy();
            
            var gameFieldProvider = new GameFieldProvider(gameField);
            Container.Bind<IGameFieldProvider>().FromInstance(gameFieldProvider).AsSingle();

            Container.Instantiate<MoveController>();
            Container.Instantiate<PlayerAttackController>();
            Container.Bind<PlayerController>().AsSingle();
            Container.Bind<EnemyFactory>().AsSingle();
        }
    }
}