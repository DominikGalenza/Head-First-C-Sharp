namespace ExtensionMethod
{
	static class AmazeballsSerum
	{
		public static string BreakWalls(this OrdinaryHuman human, double wallDensity)
		{
			return ($"I broke through a wall of {wallDensity} density.");
		}
	}
}
