using GigaChess.GameEngine.Model.Dto;

namespace GigaChess.GameEngine.Model.Converters;

public interface IFenConverter
{
    string ConvertTo(GameContext context);
    GameContext ConvertFrom(string fen);
}