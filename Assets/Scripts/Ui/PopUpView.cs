using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class PopUpView : MonoBehaviour
    {
        [SerializeField] private Pool pool;

        private void Awake() => pool.CreatePool();
    }
}
