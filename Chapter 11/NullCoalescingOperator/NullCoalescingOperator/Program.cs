#nullable enable
using (StringReader stringReader = new StringReader(""))
{
	string nextLine = stringReader.ReadLine() ?? string.Empty;
	Console.WriteLine($"Line length is : {nextLine.Length}");
}