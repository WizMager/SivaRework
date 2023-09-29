using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using System;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class EnemyView : MonoBehaviour, IDamagable
    {
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private EEnemyType enemyType;

        public EEnemyType EnemyType => enemyType;

        private void Start()
        {
            foreach (var item in enemyParameters.EnemyParameters)
            {
                for (int i = 0; i < 11; i++)
                {
                    var p = item.parametersValue[i];
                    Debug.Log($"Enemy {p.eParameters} = {p.Value}");
                }
            }
        }

        public void ReceiveDamage(float damage)
        {
            Debug.Log($"ReceiveDamage {damage}");
        }
    }
}
