using UnityEngine;

namespace Utils
{
    public class GameField : MonoBehaviour
    {
        [SerializeField] private GameObject player;

        public GameObject Player => player;
    }
}