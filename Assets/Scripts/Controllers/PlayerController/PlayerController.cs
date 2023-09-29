﻿using Assets.Scripts.CharacterParameters.Interfaces;
using Controllers.CharacteristicsController;
using Services.GameFieldProvider;
using Views;

namespace Controllers.PlayerController
{
    public class PlayerController
    {
        private readonly ParametersController _parametersController;

        public PlayerController(IGameFieldProvider gameFieldProvider, IPlayerParameters playerParameters)
        {
            var player = gameFieldProvider.GameField.Player.GetComponent<PlayerView>();

            var parameters = playerParameters.GetParametersByType(player.PlayerType);

            _parametersController = new ParametersController(parameters);
        }
    }
}
