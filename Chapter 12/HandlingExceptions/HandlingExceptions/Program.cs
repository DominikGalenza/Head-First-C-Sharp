string firstLine = "No first line was read";
try
{
	string[] lines = File.ReadAllLines(args[0]);
	firstLine = lines.Length > 0 ? lines[0] : "The file was empty";
}
catch (IndexOutOfRangeException)
{
	Console.Error.WriteLine("Please specify a filename.");
}
catch (FileNotFoundException)
{
	Console.Error.WriteLine($"Unable to find file: {args[0]}");
}
catch (UnauthorizedAccessException exception)
{
	Console.Error.WriteLine($"File {args[0]} could not be accessed: {exception}");
}
finally
{
	Console.WriteLine(firstLine);
}