using Casino.data.model;

namespace Casino.game.shuffleMechanism;

public class ShuffleAlgorithmImpl : IShuffleAlgorithm
{
    private readonly Random _random = new();

    public Deck Shuffle(Deck cardDeck)
    {
        var listOfCards = cardDeck.CardDeck;
        for (var i = 1; i < listOfCards.Count - 1; i++)
        {
            var randomIndex = _random.Next(listOfCards.Count - 1);
            (listOfCards[randomIndex], listOfCards[i - 1]) = (listOfCards[i - 1], listOfCards[randomIndex]);
        }

        return new Deck(listOfCards);
    }
}