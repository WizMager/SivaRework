using Abilities;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ui.Abilities
{
    [CreateAssetMenu(menuName = "Ability/AllAbility", fileName = "AllAbility")]
    public class AbilityListBase : ScriptableObject
    {
        [SerializeField] private List<ClassAbilityBase> _allAbilities;

        public List<ClassAbilityBase> AbilityBases => _allAbilities;
    }
}
