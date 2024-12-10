using GigaChess.GameEngine.Model.Dto;

namespace GigaChess.GameEngine.Model.Operation;

public class Game
{
    public Guid Id { get; init; }
    public IList<Piece> Pieces { get; init; }
    public GameContext GameContext { get; init; }

    public override string ToString()
    {
        return base.ToString();
    }
}