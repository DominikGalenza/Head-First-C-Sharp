﻿string filename = "DeckOfCards.txt";
Deck deck = new Deck();
deck.Shuffle();
for (int i = deck.Count - 1; i > 9; i--)
{
	deck.RemoveAt(i);
}
deck.WriteCards(filename);

Deck cardsToRead = new Deck(filename);
foreach (Card card in cardsToRead)
{
	Console.WriteLine(card.Name);
}