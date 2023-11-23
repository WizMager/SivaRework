using Assets.Scripts.Abilitys;
using CharacterParameters.Interfaces;
using Controllers.CharacteristicsController;
using Services.GameFieldProvider;
using Views;

namespace Controllers.PlayerController
{
    public class PlayerController
    {
        private readonly ParametersController _parametersController;

        public PlayerController(IGameFieldProvider gameFieldProvider, IPlayerParametersBase playerParameters)
        {
            var player = gameFieldProvider.GameField.Player.GetComponent<PlayerView>();

            var parameters = playerParameters.GetParametersByType(player.PlayerType);

            _parametersController = new ParametersController(parameters.parametersValue);
        }
    }
}
