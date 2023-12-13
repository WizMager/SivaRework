using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class PoolObject : MonoBehaviour
    {
        public void ReturnToPool()
        {
            gameObject.SetActive(false);
        }
    }
}
