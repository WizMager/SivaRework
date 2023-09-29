using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace CharacterParameters.Interfaces
{
    public interface IPlayerParametersBase
    {
        public PlayerParameters GetParametersByType(EPlayerType unitsType);
    }
}
