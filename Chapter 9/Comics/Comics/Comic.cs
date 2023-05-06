namespace Comics
{
	class Comic
	{
		public static readonly IEnumerable<Comic> Catalog = new List<Comic>
		{
			new Comic { Name = "Johnny America vs. the Pinko", Issue = 6 },
			new Comic { Name = "Rock and Roll (limited edition)", Issue = 19 },
			new Comic { Name = "Woman's Work", Issue = 36 },
			new Comic { Name = "Hippie Madness (misprinted)", Issue = 57 },
			new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
			new Comic { Name = "Black Monday", Issue = 74 },
			new Comic { Name = "Tribal Tattoo Mandess", Issue = 83 },
			new Comic { Name = "The Death of the Object", Issue = 97 }
		};
		public static readonly IReadOnlyDictionary<int, decimal> Prices = new Dictionary<int, decimal>
		{
			{ 6, 3600m },
			{ 19, 500m },
			{ 36, 650m },
			{ 57, 13525m },
			{ 68, 250m },
			{ 74, 75m },
			{ 83, 25.75m },
			{ 97, 35.25m }
		};
		public string Name { get; set; }
		public int Issue { get; set; }

		public override string ToString() => $"{Name} (Issue #{Issue})";
	}
}
