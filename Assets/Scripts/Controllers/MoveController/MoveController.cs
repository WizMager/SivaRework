using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using Controllers.InputController;
using Services.GameFieldProvider;
using UnityEngine;
using Zenject;

namespace Controllers.MoveController
{
    public class MoveController
    {
        private readonly GameObject _player;
        private Camera _camera;

        private bool _isPressed;

        public MoveController(
            IGameFieldProvider gameFieldProvider,
            IInputController inputController
        )
        {
            _player = gameFieldProvider.GameField.Player;
            _camera = gameFieldProvider.GameField.Camera;
            inputController.Move += OnMove;
            inputController.RotateMouse += OnRotateCamera;
            inputController.GetRotateCamera += StartCameraRotate;
        }

        private void StartCameraRotate(bool isPressed)
        {
            _isPressed = isPressed;
        }

        private void OnRotateCamera(float value)
        {
            if (!_isPressed) return;
            var y = Time.deltaTime * 5 * value; 
            _camera.transform.RotateAround(_player.transform.position, Vector3.up, y);
        }

        private void OnMove(Vector2 moveDirection)
        {
            var newPosition = _player.transform.position;
            newPosition.x += moveDirection.x;
            newPosition.z += moveDirection.y;
            _player.transform.position = newPosition;
        }
    }
}