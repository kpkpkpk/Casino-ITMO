using Casino.game.shuffleMechanism;

namespace Casino.data.model;

public class Croupier
{
    public Deck CardDeck { get; }

    public Croupier(IShuffleAlgorithm shuffleAlgorithm, Deck cardDeck)
    {
        CardDeck = shuffleAlgorithm.Shuffle(cardDeck);
    }
}