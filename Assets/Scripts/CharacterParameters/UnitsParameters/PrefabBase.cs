using System;
using Assets.Scripts.CharacterParameters.Interfaces;
using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;

namespace CharacterParameters.UnitsParameters
{
    [CreateAssetMenu(menuName = "Settings/PrefabBaseParameters", fileName = "PrefabBase")]
    public class PrefabBase : ScriptableObject, IPrefabBase
    {
        [SerializeField] private PrefabBaseVo[] prefabBase;
        
        public GameObject GetPrefabBase(string prefabName)
        {
            foreach (var item in prefabBase)
            {
                if (item.prefabName != prefabName) continue;
                return item.prefabBase;
            }
            throw new Exception($"{nameof(PlayerParametersBase)}; there is no parameters with UnitClass {prefabName} ");
        }
    }
}
