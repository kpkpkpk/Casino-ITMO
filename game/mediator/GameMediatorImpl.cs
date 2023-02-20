using Casino.data.model;

namespace Casino.game.mediator;

public class GameMediatorImpl: GameMediator
{
    private readonly Croupier _croupier;

    public GameMediatorImpl(Croupier croupier)
    {
        _croupier = croupier;
    }
    public void someFunction(Player player)
    {
        throw new NotImplementedException();
    }
}