using Assets.Scripts.CharacterParameters.UnitsParameters;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Abilitys
{
    [CreateAssetMenu(fileName = "AbilityBase", menuName = "Ability/AbilityBase")]
    public class AbilityBase : ScriptableObject
    {
        [SerializeField] private List<AbilityParameters> _abilities;

        public List<AbilityParameters> AllAbilities => _abilities;

        public AbilityParameters GetAbilityByName(EAbilityName abilityName)
        {
            foreach (var ability in _abilities)
            {
                if (ability.abilityName != abilityName) continue;

                return ability;
            }

            throw new Exception($"There is no ability with name: {abilityName}");
        }

        public List<AbilityParameters> GetAbilityForClass(EPlayerType classType)
        {
            var abilitiesList = new List<AbilityParameters>();

            foreach (var ability in _abilities)
            {
                if (ability.classType != EPlayerType.warrior || ability.classType != classType) continue;

                abilitiesList.Add(ability);
            }

            return abilitiesList;
        }
    }
}
