using UnityEngine;
using Views;

namespace Assets.Scripts.Controllers.PlayerAttackController
{
    public class PlayerAttackView : MonoBehaviour
    {
        [SerializeField] private Collider hitCollider;
        [SerializeField] private float attackCooldown = 1;

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out EnemyView enemy))
            {
                enemy.ReceiveDamage(10);
                Debug.Log("Take it !!");
            }
            else Debug.Log("Who are we attacking?");
        }

        public void AttackCollider(bool isActive)
        {
            hitCollider.enabled = isActive;
        }
    }
}
