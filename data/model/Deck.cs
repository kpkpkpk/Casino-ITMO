using Casino.data.model.card;

namespace Casino.data.model;

public class Deck
{
    public List<Card> CardDeck { get; }

    public Deck(List<Card> cardDeck)
    {
        CardDeck = cardDeck;
    }
}