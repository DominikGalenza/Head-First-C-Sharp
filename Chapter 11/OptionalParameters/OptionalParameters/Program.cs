static void CheckTemperature(double temperature, double tooHigh = 99.5, double tooLow = 96.5)
{
	if (temperature < tooHigh && temperature > tooLow)
	{
		Console.WriteLine($"{temperature} degrees F - feeling good!");
	}
	else
	{
		Console.WriteLine($"Uh-oh {temperature} degrees F -- better see a doctor!");
	}
}

CheckTemperature(101.3);
CheckTemperature(101.3, 102.5, 100.5);
CheckTemperature(96.2, tooLow: 95.5);