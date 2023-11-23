using Controllers.Interfaces;
using Controllers.MainController;
using System;
using UnityEngine;

namespace Controllers.InputController.Impl
{
    public class InputController : IInputController, IStart, IUpdate
    {
        public Action<Vector2> Move { get; set; }
        public Action<float> RotateMouse { get ; set; }
        public Action<bool> GetRotateCamera { get ; set ; }
        public Action SimpleAttack { get; set ; }
        public Action<int> FirstAbility { get ; set ; }

        private readonly Controls _controls = new ();
                
        public InputController(IMainController mainController)
        {
            mainController.AddController(this);
            
            _controls.Enable();
        }

        public void OnStart()
        {
            _controls.KeyboardAndMouse.SimpleAttack.performed += context => SimpleAttack.Invoke();

            _controls.KeyboardAndMouse.GetRotateCamera.performed += context => GetRotateCamera.Invoke(true);
            _controls.KeyboardAndMouse.GetRotateCamera.canceled += context => GetRotateCamera.Invoke(false);

            _controls.KeyboardAndMouse.RotateMouse.performed += context => RotateMouse.Invoke(context.ReadValue<float>());
            _controls.KeyboardAndMouse.FirstAbility.performed += context => FirstAbility.Invoke(0);
        }

        public void OnUpdate()
        {
            var keyboardAndMouse = _controls.KeyboardAndMouse.Move;

            if (keyboardAndMouse.inProgress)
            {
                var movementInput = keyboardAndMouse.ReadValue<Vector2>();
                Move?.Invoke(movementInput);
            }
        }
    }
}