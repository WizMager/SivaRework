namespace Assets.Scripts.Abilitys
{
    public class AbilityParametersController 
    {
        private SkillsParameters _abilitysParameters;

        public AbilityParametersController(AbilityParameters abilityParameters)
        {
            _abilitysParameters = new SkillsParameters(abilityParameters.abilitysValues);
        }

        public ref float GetParametersRefAbility(EAbilityParameters eAbilityParameters)
        {
            return ref _abilitysParameters.GetParametersRefAbility(eAbilityParameters);
        }
    }
}
