using System.Collections.Generic;

namespace Abilities
{
    public class AbilityParametersController 
    {
        private readonly SkillsParameters _abilitiesParameters;

        public AbilityParametersController(List<AbilityParameters> abilityParameters)
        {
            foreach (var ability in abilityParameters)
            {
                _abilitiesParameters = new SkillsParameters(ability.abilitiesValues);
            }
        }

        public ref float GetParametersRefAbility(EAbilityParameters eAbilityParameters)
        {
            return ref _abilitiesParameters.GetParametersRefAbility(eAbilityParameters);
        }
    }
}
