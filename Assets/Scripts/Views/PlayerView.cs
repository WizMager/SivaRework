using CharacterParameters.Interfaces;
using UnityEngine;

namespace Views
{
    public class PlayerView : MonoBehaviour,
    IDamagable
    {
        public void ReceiveDamage(float damage)
        {
            Debug.Log($"ReceiveDamage {damage}");
        }
    }
}