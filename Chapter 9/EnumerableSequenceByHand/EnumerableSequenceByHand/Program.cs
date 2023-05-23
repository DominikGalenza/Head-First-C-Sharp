ManualSportSequence sports = new ManualSportSequence();
BetterSportSequence anotherSports = new BetterSportSequence();

foreach (var sport in sports)
{
	Console.WriteLine(sport);
}

foreach (var sport in anotherSports)
{
	Console.WriteLine(sport);
}
Console.WriteLine(anotherSports[3]);