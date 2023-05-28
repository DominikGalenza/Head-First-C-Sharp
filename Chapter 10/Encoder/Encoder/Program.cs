using System.Text;

using (var ms = new MemoryStream())
{
	using (var sw = new StreamWriter(ms))
	{
		sw.WriteLine($"The value is {123.45678:0.00}");
	}
	Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
}