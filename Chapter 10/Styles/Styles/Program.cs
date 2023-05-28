using System.Text.Json;

List<Guy> guys = new List<Guy>()
{
	new Guy() { Name = "Bob", Clothes = new Outfit() { Top = "t-shirt", Bottom = "jeans" }, Hair = new HairStyle() { Color = HairColor.Red, Length = 3.5f} },
	new Guy() { Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" }, Hair = new HairStyle() { Color = HairColor.Gray, Length = 2.7f} }
};

JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
string jsonString = JsonSerializer.Serialize(guys, options);
Console.WriteLine(jsonString);

List<Guy>? copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
foreach (Guy guy in copyOfGuys)
{
	Console.WriteLine($"I deserialized this guy: {guy}");
}

Stack<Dude>? dudes = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);
while (dudes.Count > 0)
{
	Dude dude = dudes.Pop();
	Console.WriteLine($"Next dude: {dude.Name} with {dude.Hair} hair");
}