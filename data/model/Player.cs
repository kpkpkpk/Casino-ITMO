using Casino.game.mediator;

namespace Casino.data.model;

public class Player
{
    private readonly GameMediator _gameMediator;

    public Player(GameMediator gameMediator)
    {
        _gameMediator = gameMediator;
    }

    //TODO обращение к крупье
    public void someFoo()
    {
        _gameMediator.someFunction(this);
    }
}