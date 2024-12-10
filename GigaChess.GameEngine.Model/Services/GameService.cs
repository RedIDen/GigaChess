using GigaChess.GameEngine.Model.Converters;

namespace GigaChess.GameEngine.Model.Services;

public class GameService : IGameService
{
    private readonly IFenConverter _fenConverter;

    public GameService(IFenConverter fenConverter)
    {
        _fenConverter = fenConverter;
    }
    
    public bool TryMove(string currentGameFen, string from, string to, out string newGameFen)
    {
        throw new NotImplementedException();
        // var gameConext = _fenConverter.ConvertFrom(currentGameFen);
        // var currentMove
    }
}