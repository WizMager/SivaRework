using Assets.Scripts.CharacterParameters.UnitsParameters;
using CharacterParameters.UnitsParameters;
using System;

namespace Controllers.CharacteristicsController
{
    public class ParametersController
    {
        private readonly Parameters _parameters;

        public ParametersController(ParametersValue[] parameters)
        {
            _parameters = new Parameters(parameters);
        }

        public ref float GetParametersRef(EParameters eParameters)
        {
            return ref _parameters.GetParametersRef(eParameters);
        }

        public float GetParameter(EParameters parameter)
        {
            switch (parameter)
            {
                case EParameters.Armor:
                    var armor = _parameters.GetParameter(EParameters.Armor);
                    return armor;
                case EParameters.CritRate:
                    var critRate = _parameters.GetParameter(EParameters.CritRate);
                    return critRate;
                case EParameters.Dexterity:
                    var dexterity = _parameters.GetParameter(EParameters.Dexterity);
                    return dexterity;
                case EParameters.EnergyRecovery:
                    var energyRecovery = _parameters.GetParameter(EParameters.EnergyRecovery);
                    return energyRecovery;
                case EParameters.HealthRecovery:
                    var healthRecovery = _parameters.GetParameter(EParameters.HealthRecovery);
                    return healthRecovery;
                case EParameters.Power:
                    var power = _parameters.GetParameter(EParameters.Power);
                    return power;
                case EParameters.MoveSpeed:
                    var moveSpeed = _parameters.GetParameter(EParameters.MoveSpeed);
                    return moveSpeed;
                case EParameters.Wisdom:
                    var wisdom = _parameters.GetParameter(EParameters.Wisdom);
                    return wisdom;
                case EParameters.CurrentHealth:
                    var currentHealth = _parameters.GetParameter(EParameters.CurrentHealth);
                    return currentHealth;
                case EParameters.MaxHealth:
                    var maxHealth = _parameters.GetParameter(EParameters.MaxHealth);
                    return maxHealth;
                case EParameters.Mana:
                    var mana = _parameters.GetParameter(EParameters.Mana);
                    return mana;
                case EParameters.UltimateEnergy:
                    var ultimateEnergy = _parameters.GetParameter(EParameters.UltimateEnergy);
                    return ultimateEnergy;
                default:
                    throw new Exception("Parameter not found");
            }
        }

        public void ChangeParameter(EParameters parameter, float value)
        {            
            switch (parameter)
            {
                case EParameters.Armor:
                    break;
                case EParameters.CritRate:
                    break;
                case EParameters.Dexterity:
                    //parameters.SetParameter(EParameters.CritRate, value * 0.02f); // for example
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
                case EParameters.CurrentHealth:
                    break;
                case EParameters.MaxHealth:
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
