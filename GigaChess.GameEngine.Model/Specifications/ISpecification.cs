using GigaChess.GameEngine.Model.Dto;

namespace GigaChess.GameEngine.Model.Specifications;

public interface ISpecification
{
    bool IsSatisfiedBy(GameContext gameContext, Move move);
}