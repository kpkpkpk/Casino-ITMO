using Casino.data.model.card;
using Casino.game.shuffleMechanism;

namespace Casino.data.model;

public class Croupier
{
    public List<Card> CardDeck { get; }

    public Croupier(IShuffleAlgorithm shuffleAlgorithm, List<Card> cardDeck)
    {
        CardDeck = shuffleAlgorithm.Shuffle(cardDeck);
    }
}