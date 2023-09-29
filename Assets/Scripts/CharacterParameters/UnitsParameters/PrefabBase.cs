using Assets.Scripts.CharacterParameters.Interfaces;
using System;
using UnityEngine;

namespace Assets.Scripts.CharacterParameters.UnitsParameters
{
    [CreateAssetMenu(menuName = "Settings/PrefabBaseParameters", fileName = "PrefabBase")]
    public class PrefabBase : ScriptableObject, IBaseParameters
    {
        [SerializeField] private PrefabBaseVo[] _prefabBase;

        public PrefabBaseVo[] PrefabBases => _prefabBase;

        public GameObject GetPrefabBase(string prefabName)
        {
            foreach (var item in _prefabBase)
            {
                if (item.prefabName != prefabName) continue;
                return item.prefabBase;
            }
            throw new Exception($"{nameof(PlayerParametersBase)}; there is no parameters with UnitClass {prefabName} ");
        }
    }
}
