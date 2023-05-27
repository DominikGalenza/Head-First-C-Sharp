string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
StreamReader reader = new StreamReader($"{folder}{Path.DirectorySeparatorChar}secret_plan.txt");
StreamWriter writer = new StreamWriter($"{folder}{Path.DirectorySeparatorChar}emailToCaptainA.txt");

writer.WriteLine("To: CaptainAmazing@objectville.net");
writer.WriteLine("From: Commissioner@objectville.net");
writer.WriteLine("Subject: Can you save the day... again?");
writer.WriteLine();
writer.WriteLine("We've discovered the Swindler's terrible plan:");

while (!reader.EndOfStream)
{
	string? lineFromThePlan = reader.ReadLine();
	writer.WriteLine($"the plan -> {lineFromThePlan}");
}
writer.WriteLine();
writer.WriteLine("Can you help us?");

writer.Close();
reader.Close();