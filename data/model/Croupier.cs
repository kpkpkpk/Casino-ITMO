using Casino.data.model.card;
using Casino.game.shuffleMechanism;

namespace Casino.data.model;

public class Croupier
{
    public Deck Deck { get; private set; }
    private readonly IShuffleAlgorithm _shuffleAlgorithm;

    public Croupier(IShuffleAlgorithm shuffleAlgorithm, Deck cardDeck)
    {
        _shuffleAlgorithm = shuffleAlgorithm;
        Deck = cardDeck;
    }

    public void ShuffleDeck()
    {
        Deck = _shuffleAlgorithm.Shuffle(Deck);
    }
}