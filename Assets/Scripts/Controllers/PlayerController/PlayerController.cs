using Abilities;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using Controllers.CharacteristicsController;
using Controllers.InputController;
using Services.GameFieldProvider;
using Views;

namespace Controllers.PlayerController
{
    public class PlayerController
    {
        private readonly ParametersController _parametersController;

        public PlayerController(
            IGameFieldProvider gameFieldProvider, 
            IPlayerParametersBase playerParameters, 
            IInputController inputController,
            IAbilityBase abilityBase,
            AbilityButtonsView abilityButtonsView
        )
        {
            var player = gameFieldProvider.GameField.Player.GetComponent<PlayerView>();

            var parameters = playerParameters.GetParametersByType(player.PlayerType);

            _parametersController = new ParametersController(parameters.parametersValue);
            var abilityController = new AbilityController(inputController, abilityBase.GetAbilityForClass(EPlayerType.warrior)[0], abilityButtonsView);
        }
    }
}
