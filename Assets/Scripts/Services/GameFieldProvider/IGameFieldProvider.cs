using Utils;

namespace Services.GameFieldProvider
{
    public interface IGameFieldProvider
    {
        public GameField GameField { get; }
    }
}