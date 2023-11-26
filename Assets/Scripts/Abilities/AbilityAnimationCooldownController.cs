using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Abilities
{
    public class AbilityAnimationCooldownController : MonoBehaviour
    {
        [SerializeField] private float cooldownTime = 5f;
        [SerializeField] private Image fillImage;
        [SerializeField] private Text counterText;
        [SerializeField] private Button abilityButton;

        private void Start()
        {
            fillImage.fillAmount = 0f;
            counterText.text = "";
        }

        public void ActivateCooldown()
        {
            abilityButton.interactable = false;
            abilityButton.transform.localScale = new Vector3(0.98f, 0.98f, 1f);
            StartCoroutine(CooldownCoroutine());
        }

        private IEnumerator CooldownCoroutine()
        {
            Debug.Log("sss");
            float currentTime = cooldownTime;
            while (currentTime > 0f)
            {
                currentTime -= Time.deltaTime;
                fillImage.fillAmount = currentTime / cooldownTime;
                counterText.text = Mathf.Ceil(currentTime).ToString();
                if (currentTime <= 0.1f)
                {
                    counterText.text = "";
                }
                yield return null;
            }

            abilityButton.interactable = true;
            abilityButton.transform.localScale = new Vector3(1f, 1f, 1f);
            fillImage.fillAmount = 0f;
        }
    }
}
