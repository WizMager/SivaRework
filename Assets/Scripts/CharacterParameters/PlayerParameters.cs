using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.Parameters;
using System;
using UnityEngine;

namespace Assets.Scripts.CharacterParameters
{
    [CreateAssetMenu(menuName = "Settings/PlayerParameters", fileName = "PlayerParameters")]
    public class PlayerParameters : ScriptableObject, IPlayerParameters
    {
        [SerializeField] private UnitParameters[] unitParameters;

        public UnitParameters GetParametersByType(EUnitClass eUnitClass)
        {
            foreach (var item in unitParameters)
            {
                if (item.eUnitClass != eUnitClass) continue;
                return item;
            }
            throw new Exception($"{nameof(PlayerParameters)}; there is no parameters with UnitClass {eUnitClass} ");
        }
    }
}
