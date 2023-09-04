using System;
using Controllers.Interfaces;
using Controllers.MainController;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers.InputController.Impl
{
    public class InputController : IInputController, IUpdate
    {
        public Action<Vector2> Move { get; set; }
        public Action<float> RotateMouse { get ; set; }
        public Action<bool> GetRotateCamera { get ; set ; }

        private readonly Controls _controls = new ();
        
        public InputController(IMainController mainController)
        {
            mainController.AddController(this);
            
            _controls.Enable();
        }
        
        public void OnUpdate()
        {
            var keyboardAndMouse = _controls.KeyboardAndMouse;
            var isPressed = keyboardAndMouse.GetRotateCamera.inProgress;

            if (!isPressed) { }
            else if (isPressed == Input.GetKeyDown(KeyCode.Space))
            {
                GetRotateCamera?.Invoke(isPressed);
            }

            if (isPressed)
            {
                var rotateCamera = keyboardAndMouse.RotateMouse.ReadValue<float>();
                RotateMouse?.Invoke(rotateCamera);
            }

            if (keyboardAndMouse.Move.phase == InputActionPhase.Started)
            {
                var movementInput = keyboardAndMouse.Move.ReadValue<Vector2>();
                Move?.Invoke(movementInput); 
            }
        }        
    }
}