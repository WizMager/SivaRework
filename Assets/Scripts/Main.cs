using System;
using Controllers;
using Controllers.MainController.Impl;
using UniRx;
using UnityEngine;
using Zenject;

public class Main : MonoBehaviour
{
    [Inject] private MainController _mainController;
    
    private void Awake()
    {
        _mainController.Awake();
    }

    private void Start()
    {
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