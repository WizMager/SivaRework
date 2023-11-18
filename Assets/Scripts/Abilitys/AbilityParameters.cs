using Assets.Scripts.CharacterParameters.UnitsParameters;
using System;

namespace Assets.Scripts.Abilitys
{
    [Serializable]
    public class AbilityParameters
    {
        public AbilitysValue[] abilitysValues;
        public EAbilityName abilityName;
        public EPlayerType classType;
    }
}
