using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class PoolObject : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private PoolObject _poolObject;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _speedTextUp; // for slow text moving 

        public void PopUpElement(string damage, Vector3 position)
        {
            _text.text = damage;
            transform.position = position;
            StartCoroutine(TextFky(_lifeTime));
        }

        private IEnumerator TextFky(float time)
        {
            float X = Random.Range(-1f, 1f);
            Vector3 positionTextDamage = new Vector3(X, 0, 0);

            for (float i = 0; i < time;)
            {
                var deltaTime = Time.deltaTime;
                i += deltaTime;
                _text.alpha = Mathf.Lerp(0.3f, 1, 1 - i / time);
                positionTextDamage.y += (deltaTime / _speedTextUp);
                _text.transform.position += positionTextDamage;

                yield return null;
            }

            _poolObject.ReturnToPool();
        }

        public void ReturnToPool()
        {
            gameObject.SetActive(false);
        }
    }
}
