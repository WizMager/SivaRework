﻿using Utils;

namespace Services.GameFieldProvider.Impl
{
    public class GameFieldProvider : IGameFieldProvider
    {
        public GameField GameField { get; }
        
        public GameFieldProvider(GameField gameField)
        {
            GameField = gameField;
        }
    }
}