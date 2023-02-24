using Casino.data.model;
using Casino.game;
using Casino.game.shuffleMechanism;

//TestClass 
var gameCard = new GameDeckFactory().Create();
foreach (var p in gameCard.CardDeck)
{
    Console.WriteLine(p.CardRank + " " + p.CardSuit);
}

Console.WriteLine("\n");
var croupier = new Croupier(new ShuffleAlgorithmImpl(), gameCard);
croupier.ShuffleDeck();
foreach (var sC in croupier.Deck.CardDeck)
{
    Console.WriteLine(sC.CardRank + " " + sC.CardSuit);
}