using System;
using Controllers.InputController;
using Controllers.Interfaces;
using Services.GameFieldProvider;
using UnityEngine;

namespace Controllers.MoveController
{
    public class MoveController
    {
        private readonly GameObject _player;
        
        public MoveController(
            IGameFieldProvider gameFieldProvider,
            IInputController inputController
        )
        {
            _player = gameFieldProvider.GameField.Player;
            inputController.Move += OnMove;
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