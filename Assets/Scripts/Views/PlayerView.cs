using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using UnityEngine;

namespace Views
{
    public class PlayerView : MonoBehaviour, IDamagable
    {
        [SerializeField] private EPlayerType playerType;

        public EPlayerType PlayerType => playerType;

        public void ReceiveDamage(float damage)
        {
            //Debug.Log($"ReceiveDamage {damage}");
        }
    }
}