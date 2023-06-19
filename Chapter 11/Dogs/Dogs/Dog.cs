namespace Dogs
{
	public struct Dog
	{
		public string Name { get; set; }
		public string Breed { get; set; }

		public Dog(string name, string breed)
		{
			Name = name;
			Breed = breed;
		}

		public void Speak()
		{
			Console.WriteLine($"My name is {Name} and I'm a {Breed}");
		}
	}
}