using System;
using Assets.Scripts.Factory.ConcreteFactory;
using Controllers;
using Controllers.MainController.Impl;
using UniRx;
using UnityEngine;
using Zenject;

public class Main : MonoBehaviour
{
    [Inject] private MainController _mainController;
    [Inject] private EnemyFactory _enemyFactory;
            
    private void Awake()
    {
        _mainController.Awake();
    }

    private void Start()
    {
        _mainController.Start();
        _enemyFactory.CreateZombie();
    }

    private void Update()
    {
        _mainController.Update();
    }

    private void FixedUpdate()
    {
       _mainController.FixedUpdate(); 
    }

    private void LateUpdate()
    {
        _mainController.LateUpdate();
    }

    private void OnDestroy()
    {
        _mainController.Destroy();
    }
}