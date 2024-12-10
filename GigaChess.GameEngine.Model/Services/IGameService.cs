namespace GigaChess.GameEngine.Model.Services;

public interface IGameService
{
    bool TryMove(string currentGameFen, string from, string to, out string newGameFen);
}