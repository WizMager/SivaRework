using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Abilitys
{
    public class AbilityButtonView : MonoBehaviour
    {
        [SerializeField] private List<AbilityButton> abilityButtons;

        public List<AbilityButton> AbilityButtons => abilityButtons;
    }
}
