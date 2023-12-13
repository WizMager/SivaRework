using System;
using Assets.Scripts.CharacterParameters.Interfaces;
using CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.CharacterParameters.UnitsParameters
{
    [CreateAssetMenu(menuName = "Settings/EnemyParameters", fileName = "EnemyParameters")]
    public class EnemyParametersBase : ScriptableObject, IEnemyParameters
    {
        [SerializeField] private EnemyParameters[] enemyParameters;

        public EnemyParameters GetParametersByType(EEnemyType enemyType)
        {
            foreach (var item in enemyParameters)
            {
                if (item.enemyType != enemyType) continue;
                return item;
            }
            throw new Exception($"{nameof(EnemyParametersBase)}; there is no parameters with UnitClass {enemyType} ");
        }
    }
}
