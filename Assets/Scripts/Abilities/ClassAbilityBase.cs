using System;
using System.Collections.Generic;
using Assets.Scripts.Abilities;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Abilities
{
    [CreateAssetMenu(fileName = "AbilityBase", menuName = "Ability/ClassAbilityBase")]
    public class ClassAbilityBase : ScriptableObject, IAbilityBase
    {
        [SerializeField] private List<AbilityBase> _abilities;
        [SerializeField] private EPlayerType _classType;

        public List<AbilityBase> AllAbilities => _abilities;

        public AbilityParameters GetAbilityByName(EAbilityName abilityName)
        {
            foreach (var ability in _abilities)
            {
                if (ability.AllAbilities.abilityName != abilityName) continue;

                return ability.AllAbilities;                
            }

            throw new Exception($"There is no ability with name: {abilityName}");
        }

        public List<AbilityParameters> GetAbilityForClass(EPlayerType classType)
        {
            var abilitiesList = new List<AbilityParameters>();

            foreach (var ability in _abilities)
            {
                if (_classType != classType) continue;

                abilitiesList.Add(ability.AllAbilities);
            }

            return abilitiesList;
        }
    }
}
