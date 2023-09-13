using Assets.Scripts.CharacterParameters.Parameters;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Controllers.Parameters
{
    public class ParametersController
    {
        private Dictionary<int, Parameter> _parameters;

        public void ChangeParameter(int id, EParameters parameter, float value)
        {
            var parameters = _parameters[id];

            parameters.SetParameter(parameter, value);

            switch (parameter)
            {
                case EParameters.Armor:

                    break;
                case EParameters.CritRate:
                    break;
                case EParameters.Dexterity:
                    var dexterity = parameters.GetParameter(EParameters.Dexterity);
                    var critRate = parameters.GetParameter(EParameters.CritRate);
                    critRate += dexterity * 0.02f;
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
