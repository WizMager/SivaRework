using Assets.Scripts.CharacterParameters.Interfaces;
using System;
using UnityEngine;

namespace Assets.Scripts.CharacterParameters.UnitsParameters
{
    [CreateAssetMenu(menuName = "Settings/PlayerParameters", fileName = "PlayerParameters")]
    public class PlayerParametersBase : ScriptableObject, IPlayerParameters
    {
        [SerializeField] private PlayerParameters[] playerParameters;

        public PlayerParameters[] PlayerParameters => playerParameters;
      
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
