using Casino.data.model.card;

namespace Casino.game.shuffleMechanism;

public interface IShuffleAlgorithm
{
    public List<Card> Shuffle(List<Card> cardDeck);
}