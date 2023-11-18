using Assets.Scripts.CharacterParameters.UnitsParameters;
using System;

namespace CharacterParameters.UnitsParameters
{
    public class Parameters
    {
        private float _armor;
        private float _critRate;
        private float _dexterity;
        private float _energyRecovery;
        private float _healthRecovery;
        private float _power;
        private float _moveSpeed;
        private float _wisdom;
        private float _currentHealth;
        private float _maxHealth;
        private float _mana;
        private float _ultimateEnergy;

        public Parameters(ParametersValue[] parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.eParameters)
                {
                    case EParameters.Armor:
                        _armor = parameter.value;
                        break;
                    case EParameters.CritRate:
                        _critRate = parameter.value;
                        break;
                    case EParameters.Dexterity:
                        _dexterity = parameter.value;
                        break;
                    case EParameters.EnergyRecovery:
                        _energyRecovery = parameter.value;
                        break;
                    case EParameters.HealthRecovery:
                        _healthRecovery = parameter.value;
                        break;
                    case EParameters.Power:
                        _power = parameter.value;
                        break;
                    case EParameters.MoveSpeed:
                        _moveSpeed = parameter.value;
                        break;
                    case EParameters.Wisdom:
                        _wisdom = parameter.value;
                        break;
                    case EParameters.CurrentHealth:
                        _currentHealth = parameter.value;
                        break;
                    case EParameters.MaxHealth:
                        _maxHealth = parameter.value;
                        break;
                    case EParameters.Mana:
                        _mana = parameter.value;
                        break;
                    case EParameters.UltimateEnergy:
                        _ultimateEnergy = parameter.value;
                        break;
                    case EParameters.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }        

        public ref float GetParametersRef(EParameters eParameters)
        {
            switch (eParameters)
            {
                case EParameters.Armor:
                    return ref _armor;
                case EParameters.CritRate:
                    return ref _critRate;
                case EParameters.Dexterity:
                    return ref _dexterity;
                case EParameters.EnergyRecovery:
                    return ref _energyRecovery;
                case EParameters.HealthRecovery:
                    return ref _healthRecovery;
                case EParameters.Power:
                    return ref _power;
                case EParameters.MoveSpeed:
                    return ref _moveSpeed;
                case EParameters.Wisdom:
                    return ref _wisdom;
                case EParameters.CurrentHealth:
                    return ref _currentHealth;
                case EParameters.MaxHealth:
                    return ref _maxHealth;
                case EParameters.Mana:
                    return ref _mana;
                case EParameters.UltimateEnergy:
                    return ref _ultimateEnergy;
                default:
                    throw new Exception("Parameter not found");
            }
        }

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
                case EParameters.CurrentHealth:
                    return _currentHealth;
                case EParameters.MaxHealth:
                    return _maxHealth;
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
                case EParameters.CurrentHealth:
                    _currentHealth += value;
                    break;
                case EParameters.MaxHealth:
                    _maxHealth += value;
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
