using CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.Factory.ConcreteUnits
{
    public class Warlock : Enemy
    {
        public Warlock(EEnemyType enemyType) : base(enemyType)
        {
            Debug.Log($"Created {enemyType}");
        }
    }
}
