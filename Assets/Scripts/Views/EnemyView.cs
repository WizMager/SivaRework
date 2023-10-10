using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Views
{
    public class EnemyView : MonoBehaviour, IDamagable
    {
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private EEnemyType enemyType;

        public EEnemyType EnemyType => enemyType;

        public void ReceiveDamage(float damage)
        {
            Debug.Log($"ReceiveDamage {damage} Enemy");
        }
    }
}
