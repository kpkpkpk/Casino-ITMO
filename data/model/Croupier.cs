using Casino.data.model.card;
using Casino.game.shuffleMechanism;

namespace Casino.data.model;

public class Croupier
{
    public Deck Deck { get; }

    public Croupier(IShuffleAlgorithm shuffleAlgorithm, Deck cardDeck)
    {
        Deck = shuffleAlgorithm.Shuffle(cardDeck);
    }
}