using System.Drawing;
using GigaChess.GameEngine.Model.Dto;
using GigaChess.GameEngine.Model.Enums;
using GigaChess.GameEngine.Model.Exceptions;
using GigaChess.GameEngine.Model.Specifications;

namespace GigaChess.GameEngine.Model.Operation;

public class Piece
{
    public PieceType Type { get; init; }
    public bool IsWhite { get; init; }
    public Point Position { get; private set; }

    private readonly IList<ISpecification> _moveSpecifications;

    public Piece(PieceType type, bool isWhite, Point position, IList<ISpecification> moveSpecifications)
    {
        Type = type;
        IsWhite = isWhite;
        Position = position;
        _moveSpecifications = moveSpecifications;
    }

    public bool CanMove(GameContext gameContext, Move move)
    {
        return _moveSpecifications.All(specification => specification.IsSatisfiedBy(gameContext, move));
    }
    
    public void Move(GameContext gameContext, Move move)
    {
        if (CanMove(gameContext, move))
        {
            Position = move.To;
        }
        else
        {
            throw new InvalidMoveException();
        }
    }

    public override string ToString()
    {
        return Type.ToString();
    }
}