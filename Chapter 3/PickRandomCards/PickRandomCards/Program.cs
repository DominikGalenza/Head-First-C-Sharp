using PickRandomCards;

Console.Write("Enter the number of cards to pick: ");
string line = Console.ReadLine();

if (int.TryParse(line, out int numberOfCards))
{
   string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);
	foreach (string pickedCard in pickedCards)
	{
		Console.WriteLine(pickedCard);
	}
}
else
{
	Console.WriteLine("The number was not valid.");
}