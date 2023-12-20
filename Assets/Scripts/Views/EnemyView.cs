using Assets.Scripts.CharacterParameters.UnitsParameters;
using Assets.Scripts.Ui;
using CharacterParameters.Interfaces;
using CharacterParameters.UnitsParameters;
using UnityEngine;

namespace Views
{
    public class EnemyView : MonoBehaviour, IDamagable
    {
        [SerializeField] private EnemyParametersBase enemyParameters;
        [SerializeField] private EEnemyType enemyType;

        [SerializeField] private PopUpView popUpView;
        [SerializeField] private Transform canvas;

        private Camera _mainCamera;

        public EEnemyType EnemyType => enemyType;

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void FixedUpdate()
        {
            canvas.forward = _mainCamera.transform.forward;
        }

        public void ReceiveDamage(float damage)
        {            
            popUpView.Pool.GetFreeElement().PopUpElement(damage.ToString(), canvas.position);
            Debug.Log($"ReceiveDamage {damage} Enemy");
        }
    }
}
