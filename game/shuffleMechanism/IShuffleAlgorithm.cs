using Casino.data.model;
using Casino.data.model.card;

namespace Casino.game.shuffleMechanism;

public interface IShuffleAlgorithm
{
    public Deck Shuffle(Deck cardDeck);
}