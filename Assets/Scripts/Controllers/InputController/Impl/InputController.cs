using System;
using Controllers.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers.InputController.Impl
{
    public class InputController : IInputController, IUpdate
    {
        public Action<Vector2> Move { get; set; }

        private readonly Controls _controls = new ();
        
        public InputController(MainController.Impl.MainController mainController)
        {
            mainController.AddController(this);
            
            _controls.Enable();
        }
        
        public void OnUpdate()
        {
            var keyboardAndMouse = _controls.KeyboardAndMouse;
            
            if (keyboardAndMouse.Move.phase == InputActionPhase.Started)
            {
                var movementInput = keyboardAndMouse.Move.ReadValue<Vector2>();
                Move?.Invoke(movementInput); 
            }
        }
        
    }
}