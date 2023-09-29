using Assets.Scripts.CharacterParameters.UnitsParameters;
using System;
using System.Collections.Generic;

namespace Controllers.CharacteristicsController
{
    public class ParametersController
    {
        private Dictionary<EParameters, float> _parameters = new ();

        public ParametersController(PlayerParameters parameters)
        {
            foreach (var item in parameters.parametersValue)
            {
                _parameters.Add(item.eParameters, item.Value);
            }
        }
        
        public ParametersController(EnemyParameters parameters)
        {
            foreach (var item in parameters.parametersValue)
            {
                _parameters.Add(item.eParameters, item.Value);
            }
        }

        public void ChangeParameter(EParameters parameter, float value)
        {
            Parameters a = new();
            a.SetParameter(parameter, value);

            switch (parameter)
            {
                case EParameters.Armor:
                    break;
                case EParameters.CritRate:
                    break;
                case EParameters.Dexterity:
                    a.SetParameter(EParameters.CritRate, value * 0.02f); // for example
                    break;
                case EParameters.EnergyRecovery:
                    break;
                case EParameters.HealthRecovery:
                    break;
                case EParameters.Power:
                    break;
                case EParameters.MoveSpeed:
                    break;
                case EParameters.Wisdom:
                    break;
                case EParameters.Health:
                    break;
                case EParameters.Mana:
                    break;
                case EParameters.UltimateEnergy:
                    break;
                default:
                    throw new Exception("Not found Parameter in ChangeParameter");
            }
        }
    }
}
