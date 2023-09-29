using CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Assets.Scripts.Factory.ConcreteUnits
{
    public class Zombie : Enemy
    {
        public Zombie() : base(EEnemyType.Zombie)
        {
            Debug.Log($"Created {EEnemyType.Zombie}");
        }
    }
}
