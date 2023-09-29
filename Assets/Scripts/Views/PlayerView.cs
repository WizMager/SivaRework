﻿using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.Interfaces;
using UnityEngine;

namespace Views
{
    public class PlayerView : MonoBehaviour, IDamagable
    {
        [SerializeField] private PlayerParametersBase playerParameters;
        [SerializeField] private EPlayerType playerType;

        public EPlayerType PlayerType => playerType;

        private void Start()
        {
            foreach (var item in playerParameters.PlayerParameters)
            {
                for (int i = 0; i < 11; i++)
                {
                    var p = item.parametersValue[i];
                    Debug.Log($"Player {p.eParameters} = {p.Value}");
                }
            }
        }

        public void ReceiveDamage(float damage)
        {
            Debug.Log($"ReceiveDamage {damage}");
        }
    }
}