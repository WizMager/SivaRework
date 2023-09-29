using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.Factory.ConcreteUnits
{
    public class Skeleton : Enemy
    {
        public Skeleton(EEnemyType enemyType) : base(enemyType)
        {
            Debug.Log($"Created {enemyType}");
        }
    }
}
