namespace Casino.data.model.card;

public class Card
{
    public CardSuit CardSuit { get; }
    public CardRank CardRank { get; }

    public Card(CardSuit cardSuit, CardRank cardRank)
    {
        CardSuit = cardSuit;
        CardRank = cardRank;
    }
}