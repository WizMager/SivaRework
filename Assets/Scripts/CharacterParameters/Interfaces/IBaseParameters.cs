using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.CharacterParameters.Interfaces
{
    public interface IBaseParameters
    {
        public GameObject GetPrefabBase(string prefabName);
    }
}
