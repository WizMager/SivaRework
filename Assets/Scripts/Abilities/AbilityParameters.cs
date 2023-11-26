using System;
using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Abilities
{
    [Serializable]
    public class AbilityParameters
    {
        public AbilitiesValue[] abilitiesValues;
        public EAbilityName abilityName;
        public EPlayerType classType;
    }
}
