﻿using Assets.Scripts.CharacterParameters.UnitsParameters;

namespace Assets.Scripts.CharacterParameters.Interfaces
{
    public interface IPlayerParameters
    {
        public PlayerParameters GetParametersByType(EPlayerType unitsType);
    }
}
