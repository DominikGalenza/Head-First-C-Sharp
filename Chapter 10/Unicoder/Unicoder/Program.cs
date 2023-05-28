using System.Text;
using System.Text.Json;

//File.WriteAllText("Eureka.txt", "Eureka!");
File.WriteAllText("Eureka.txt", "שלום", Encoding.Unicode);
byte[] eurekaBytes = File.ReadAllBytes("Eureka.txt");

foreach (byte b in eurekaBytes)
{
	Console.Write($"{b} ");
}
Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));

foreach (byte b in eurekaBytes)
{
	Console.Write($"{b:x2} ");
}
Console.WriteLine();

Console.WriteLine(JsonSerializer.Serialize("ש"));

File.WriteAllText("Elephant1.txt", "\uD83D\uDC18");
File.WriteAllText("Elephant2.txt", "\U0001F418");