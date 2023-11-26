using System.Collections.Generic;
using UnityEngine;

namespace Abilities
{
    public class AbilityButtonsView : MonoBehaviour
    {
        [SerializeField] private List<AbilityButton> abilityButtons;

        public List<AbilityButton> AbilityButtons => abilityButtons;
    }
}
