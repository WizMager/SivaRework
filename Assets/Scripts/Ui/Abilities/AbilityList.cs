using Abilities;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ui.Abilities
{
    public class AbilityList : MonoBehaviour
    {
        [SerializeField] private AbilityListBase _startAbilities;
        [SerializeField] private List<ClassAbilityBase> _abilities;

        private void Start()
        {
            var allAbility = _startAbilities.AbilityBases;

            for (int i = 0; i < allAbility.Count; i++)
            {
                AddAbility(allAbility[i]);
            }
        }

        private void AddAbility(ClassAbilityBase abilityBase)
        {
            _abilities.Add(abilityBase);
        }


    }
}
