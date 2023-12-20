using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class PopUpView : MonoBehaviour
    {
        [SerializeField] private Pool pool;

        public Pool Pool => pool;

        public void Awake() => pool.CreatePool();
    }
}
