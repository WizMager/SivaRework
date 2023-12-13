using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Controllers.InputController;
using Controllers.Interfaces;
using UnityEngine;

namespace Abilities
{
    public class AbilityController : IStart
    {
        private readonly List<AbilityParameters> _abilityParameters = new ();
        private readonly AbilityButtonsView _abilityButtons;
        private readonly AbilityParametersController _abilityParametersController;

        public AbilityController(
            IInputController inputController,
            List<AbilityParameters> abilityParameters,
            AbilityButtonsView abilityButtons
        )
        {
            _abilityParametersController = new AbilityParametersController(abilityParameters);
            _abilityButtons = abilityButtons;

            foreach (var ability in _abilityParameters)
            {
                _abilityParameters.Add(ability);
            }

            inputController.UseAbility += OnUseAbility;
        }

        public void OnStart()
        {
            foreach (var abilityButton in _abilityButtons.AbilityButtons)
            {
                abilityButton.image.fillAmount = 0f;
                abilityButton.text.text = "";
            }
        }

        private void OnUseAbility(int abilitySlotNumber)
        {
            if (!_abilityButtons.AbilityButtons[abilitySlotNumber].button.interactable) return;
            
            _abilityButtons.AbilityButtons[abilitySlotNumber].button.interactable = false;
            _abilityButtons.AbilityButtons[abilitySlotNumber].button.transform.localScale = new Vector3(0.98f, 0.98f, 1f);

            var abilityButton = _abilityButtons.AbilityButtons[abilitySlotNumber];

            var cooldown = _abilityParametersController.GetParametersRefAbility(EAbilityParameters.Cooldown);
            _abilityButtons.StartCoroutine(ButtonCooldown(abilityButton, cooldown));
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
            abilityButton.image.fillAmount = 1f;
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
