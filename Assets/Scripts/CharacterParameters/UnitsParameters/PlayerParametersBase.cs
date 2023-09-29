using System;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using UnityEngine;

namespace CharacterParameters.UnitsParameters
{
    [CreateAssetMenu(menuName = "Settings/PlayerParameters", fileName = "PlayerParameters")]
    public class PlayerParametersBase : ScriptableObject, IPlayerParametersBase
    {
        [SerializeField] private PlayerParameters[] playerParameters;
      
        public PlayerParameters GetParametersByType(EPlayerType unitType)
        {
            foreach (var item in playerParameters)
            {
                if (item.playerType != unitType) continue;
                return item;
            }
            throw new Exception($"{nameof(PlayerParametersBase)}; there is no parameters with UnitClass {unitType} ");
        }
    }
}
