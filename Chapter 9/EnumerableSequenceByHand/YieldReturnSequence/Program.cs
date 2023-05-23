static IEnumerable<string> SimpleEnumerable()
{
	yield return "apples";
	yield return "oranges";
	yield return "bananas";
	yield return "unicorns";
}

foreach (var simpleEnumerable in SimpleEnumerable())
{
	Console.WriteLine(simpleEnumerable);
}