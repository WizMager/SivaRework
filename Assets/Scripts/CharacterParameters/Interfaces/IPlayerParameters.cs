using Assets.Scripts.CharacterParameters.Parameters;

namespace Assets.Scripts.CharacterParameters.Interfaces
{
    public interface IPlayerParameters
    {
        public UnitParameters GetParametersByType(EUnitClass eUnitClass);
    }
}
