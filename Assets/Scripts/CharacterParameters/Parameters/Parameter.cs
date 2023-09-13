using System;

namespace Assets.Scripts.CharacterParameters.Parameters
{
    public class Parameter
    {
        private float _armor;
        private float _critRate;
        private float _dexterity;
        private float _energyRecovery;
        private float _healthRecovery;
        private float _power;
        private float _moveSpeed;
        private float _wisdom;
        private float _health;
        private float _mana;
        private float _ultimateEnergy;

        public float GetParameter(EParameters parameter) 
        {
            switch (parameter)
            {
                case EParameters.Armor:
                    return _armor;
                case EParameters.CritRate:
                    return _critRate;
                case EParameters.Dexterity:
                    return _dexterity;
                case EParameters.EnergyRecovery:
                    return _energyRecovery;
                case EParameters.HealthRecovery:
                    return _healthRecovery;
                case EParameters.Power:
                    return _power;
                case EParameters.MoveSpeed:
                    return _moveSpeed;
                case EParameters.Wisdom:
                    return _wisdom;
                case EParameters.Health:
                    return _health;
                case EParameters.Mana:
                    return _mana;
                case EParameters.UltimateEnergy:
                    return _ultimateEnergy;
                default:
                    throw new Exception("Parameter not found");
            }
        }

        public void SetParameter(EParameters parameter, float value) 
        {
            switch (parameter)
            {
                case EParameters.Armor:
                    _armor += value;
                    break;
                case EParameters.CritRate:
                    _critRate += value;
                    break;
                case EParameters.Dexterity:
                    _dexterity += value;
                    break;
                case EParameters.EnergyRecovery:
                    _energyRecovery += value;
                    break;
                case EParameters.HealthRecovery:
                    _healthRecovery += value;
                    break;
                case EParameters.Power:
                    _power += value;
                    break;
                case EParameters.MoveSpeed:
                    _moveSpeed += value;
                    break;
                case EParameters.Wisdom:
                    _wisdom += value;
                    break;
                case EParameters.Health:
                    _health += value;
                    break;
                case EParameters.Mana:
                    _mana += value;
                    break;
                case EParameters.UltimateEnergy:
                    _ultimateEnergy += value;
                    break;
                default:
                    throw new Exception("Not found parameters for SetParameters");
            }
        }        
    }
}
