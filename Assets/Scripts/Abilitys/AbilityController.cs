using Controllers.InputController;
using Controllers.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Assets.Scripts.Abilitys
{
    public class AbilityController : IStart
    {
        private List<AbilityParameters> _abilityParameters;
        private AbilityButtonView _abilityButtonView;
        private AbilityParametersController _abilityParametersController;

        public AbilityController(
            IInputController inputController,
            AbilityParameters abilityParameters)
        {
            _abilityParametersController = new AbilityParametersController(abilityParameters);

            foreach (var ability in _abilityParameters)
            {
                _abilityParameters.Add(ability);
            }

            inputController.FirstAbility += AbilitiUse;
        }

        public void OnStart()
        {
            foreach (var abilitybutton in _abilityButtonView.AbilityButtons)
            {
                abilitybutton.image.fillAmount = 0f;
                abilitybutton.text.text = "";
            }
        }

        private void AbilitiUse(int ability)
        {
            if (_abilityButtonView.AbilityButtons[ability].button.interactable)
            {
                _abilityButtonView.AbilityButtons[ability].button.interactable = false;
                _abilityButtonView.AbilityButtons[ability].button.transform.localScale = new Vector3(0.98f, 0.98f, 1f);

                var abilityButton = _abilityButtonView.AbilityButtons[ability];

                _abilityButtonView.StartCoroutine(ButtonCooldown(abilityButton, _abilityParametersController.GetParametersRefAbility(EAbilityParameters.Cooldown) /*cooldown*/ ));
            }
        }

        private IEnumerator ButtonCooldown(AbilityButton abilityButton, float cooldown)
        {
            for (float i = cooldown; i > 0;)
            {
                var deltaTime = Time.deltaTime;
                i -= deltaTime;

                ChangeAbilityButton(abilityButton, i, cooldown);

                yield return null;
            }

            abilityButton.button.interactable = true;
            abilityButton.button.transform.localScale = new Vector3(1f, 1f, 1f);
            abilityButton.image.fillAmount = 0f;
        }

        private void ChangeAbilityButton(AbilityButton abilityButton, float currentTime, float cooldown)
        {
            abilityButton.image.fillAmount = currentTime / cooldown;
            abilityButton.text.text = Mathf.Ceil(currentTime).ToString(CultureInfo.InvariantCulture);

            if (currentTime <= 0.1f)
            {
                abilityButton.text.text = "";
            }
        }
    }
}
