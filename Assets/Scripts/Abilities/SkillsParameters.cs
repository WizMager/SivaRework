using System;

namespace Abilities
{
    public class SkillsParameters
    {
         private float _cooldown;
         private float _useTime;
         private float _cost;
         private float _damageModifier;

        public SkillsParameters(AbilitiesValue[] abilitysValue)
        {
            foreach (var ability in abilitysValue)
            {
                switch (ability.eAbilityParameters)
                {
                    case EAbilityParameters.Cooldown:
                        _cooldown = ability.value;
                        break;
                    case EAbilityParameters.UseTime:
                        _useTime = ability.value;
                        break;
                    case EAbilityParameters.Cost:
                        _cost = ability.value;
                        break;
                    case EAbilityParameters.DamageModifier:
                        _damageModifier = ability.value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public ref float GetParametersRefAbility(EAbilityParameters eAbilityParameters)
        {
            switch (eAbilityParameters)
            {
                case EAbilityParameters.Cooldown:
                    return ref _cooldown;
                case EAbilityParameters.UseTime:
                    return ref _useTime;
                case EAbilityParameters.Cost:
                    return ref _cost;
                case EAbilityParameters.DamageModifier:
                    return ref _damageModifier;
                default:
                    throw new Exception("Parameter not found");
            }
        }

    }
}
