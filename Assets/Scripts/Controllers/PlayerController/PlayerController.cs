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

            var parameters = playerParameters.GetParametersByType(EPlayerType.Warrior);

            _parametersController = new ParametersController(parameters.parametersValue);

            var abilityPatametersByClass = abilityBase.GetAbilityForClass(EPlayerType.Warrior);

            var abilityController = new AbilityController(inputController, abilityPatametersByClass, abilityButtonsView);
        }
    }
}
