using System.Collections.Generic;
using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Abilities
{
    public interface IAbilityBase
    {
        public AbilityParameters GetAbilityByName(EAbilityName abilityName);
        public List<AbilityParameters> GetAbilityForClass(EPlayerType classType);
    }
}