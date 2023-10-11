using Controllers.InputController;
using Services.GameFieldProvider;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Controllers.PlayerAttackController
{
    public class PlayerAttackController
    {
        private readonly GameObject _player;
        private readonly PlayerAttackView _attackView;

        private bool _attackAwailable = true;

        public PlayerAttackController(
            IGameFieldProvider gameFieldProvider,
            IInputController inputController)
        {
            _player = gameFieldProvider.GameField.Player;
            _attackView = _player.GetComponentInChildren<PlayerAttackView>();
            inputController.SimpleAttack += PlayerAttack;
        }

        private void PlayerAttack()
        {
            if (!_attackAwailable) return;
            _attackAwailable = false;

            _attackView.AttackCollider(true);

            _attackView.StartCoroutine(AttackCooldown());
            _attackView.StartCoroutine(AttackCooldownOff());
        }

        private IEnumerator AttackCooldown()
        {
            yield return new WaitForSeconds(_attackView.AttackCooldown);
            _attackAwailable = true;
        }

        private IEnumerator AttackCooldownOff()
        {
            yield return null;
            yield return null;
            _attackView.AttackCollider(false);
        }
    }
}
