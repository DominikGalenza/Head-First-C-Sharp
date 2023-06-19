using Clones;

System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
List<EvilClone> clones = new List<EvilClone>();

while (true)
{
	switch (Console.ReadKey(true).KeyChar)
	{
		case 'a':
			clones.Add(new EvilClone());
			break;
		case 'c':
			Console.WriteLine($"Clearing list at time {stopwatch.ElapsedMilliseconds}");
			clones.Clear();
			break;
		case 'g':
			Console.WriteLine($"Collecting at time {stopwatch.ElapsedMilliseconds}");
			GC.Collect();
			break;
	}
}
