using Abilities;
using UnityEngine;

namespace Assets.Scripts.Abilities
{
    [CreateAssetMenu(fileName = "AbilityBase", menuName = "Ability/AbilityBase")]
    public class AbilityBase : ScriptableObject
    {
        [SerializeField] private AbilityParameters _abilities;

        public AbilityParameters AllAbilities => _abilities;
    }
}
