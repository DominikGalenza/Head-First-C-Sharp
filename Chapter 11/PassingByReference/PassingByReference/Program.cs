class Guy
{
	public string Name { get; set; }
	public int Age { get; set; }
	public override string ToString() => $"a {Age}-year-old named {Name}";
}

class Program
{
	static void ModifyAnIntAndGuy(ref int valueReference, ref Guy guyReference)
	{
		valueReference += 10;
		guyReference.Name = "Bob";
		guyReference.Age = 37;
	}

	static void Main(string[] args)
	{
		int i = 1;
		Guy guy = new Guy() { Name = "Joe", Age = 26 };
		Console.WriteLine($"i is {i} and guy is {guy}");
		ModifyAnIntAndGuy(ref i, ref guy);
		Console.WriteLine($"Now i is {i} and guy is {guy}");
	}
}