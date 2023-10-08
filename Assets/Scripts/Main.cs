using CharacterParameters.UnitsParameters;
using Controllers.MainController.Impl;
using Factory.ConcreteFactory;
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
        _enemyFactory.CreateEnemy(EEnemyType.Zombie);
        _mainController.Start();
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