namespace Abilities
{
    public class AbilityParametersController 
    {
        private readonly SkillsParameters _abilitiesParameters;

        public AbilityParametersController(AbilityParameters abilityParameters)
        {
            _abilitiesParameters = new SkillsParameters(abilityParameters.abilitiesValues);
        }

        public ref float GetParametersRefAbility(EAbilityParameters eAbilityParameters)
        {
            return ref _abilitiesParameters.GetParametersRefAbility(eAbilityParameters);
        }
    }
}
