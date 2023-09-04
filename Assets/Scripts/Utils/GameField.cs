using UnityEngine;

namespace Utils
{
    public class GameField : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private new Camera camera;

        public GameObject Player => player;
        public Camera Camera => camera;
    }
}