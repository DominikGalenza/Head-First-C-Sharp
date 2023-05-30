using System.Text;

int position = 0;

using (StreamReader reader = new StreamReader("TextData.txt"))
{
	while (!reader.EndOfStream)
	{
		char[] buffer = new char[16];
		int bytesRead = reader.ReadBlock(buffer, 0, buffer.Length);

		Console.Write($"{position:x4}: ");
		position += bytesRead;

		for (int i = 0; i < buffer.Length; i++)
		{
			if (i < bytesRead)
			{
				Console.Write($"{(byte)buffer[i]:x2} ");
			}
			else
			{
				Console.Write("  ");
			}
			if (i == 7)
			{
				Console.Write("-- ");
			}
		}

		string bufferContents = new string(buffer);
		Console.WriteLine($"  {bufferContents.Substring(0, bytesRead)}");
	}
}

using (Stream input = File.OpenRead("BinaryData.dat"))
{
	while (position < input.Length)
	{
		byte[] buffer = new byte[16];
		int bytesRead = input.Read(buffer, 0, buffer.Length);

		Console.Write($"{position:x4}: ");
		position += bytesRead;

		for (int i = 0; i < buffer.Length; i++)
		{
			if (i < bytesRead)
			{
				Console.Write($"{(byte)buffer[i]:x2} ");
			}
			else
			{
				Console.Write("  ");
			}
			if (i == 7)
			{
				Console.Write("-- ");
			}
			if (buffer[i] < 0x20 || buffer[i] > 0x7F)
			{
				buffer[i] = (byte)'.';
			}
		}

		string bufferContents = Encoding.UTF8.GetString(buffer);
		Console.WriteLine($"  {bufferContents.Substring(0, bytesRead)}");
	}
}

using (Stream input = File.OpenRead(args[0]))
{
	byte[] buffer = new byte[16];
	int bytesRead;

	while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
	{
		Console.Write($"{position:x4}: ");
		position += bytesRead;

		for (int i = 0; i < buffer.Length; i++)
		{
			if (i < bytesRead)
			{
				Console.Write($"{(byte)buffer[i]:x2} ");
			}
			else
			{
				Console.Write("  ");
			}
			if (i == 7)
			{
				Console.Write("-- ");
			}
			if (buffer[i] < 0x20 || buffer[i] > 0x7F)
			{
				buffer[i] = (byte)'.';
			}
		}

		string bufferContents = Encoding.UTF8.GetString(buffer);
		Console.WriteLine($"  {bufferContents.Substring(0, bytesRead)}");
	}
}