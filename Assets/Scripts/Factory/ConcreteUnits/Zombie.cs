using Assets.Scripts.CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.Factory.ConcreteUnits
{
    public class Zombie : Enemy
    {
        public Zombie() : base(EEnemyType.zombie)
        {
            Debug.Log($"Created {EEnemyType.zombie}");
        }
    }
}
