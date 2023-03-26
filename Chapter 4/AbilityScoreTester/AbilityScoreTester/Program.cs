AbilityScoreCalculator calculator = new AbilityScoreCalculator();

while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

    calculator.CalculateAbilityScore();
    Console.WriteLine($"Calculated ability score: {calculator.Score}");

    char keyChar = Console.ReadKey(true).KeyChar;
    if (keyChar == 'Q' || keyChar == 'q')
    {
        return;
    }
}

/// <summary>
/// Writes a prompt and reads an int value from the console.
/// </summary>
/// <param name="lastUsedValue">The default value.</param>
/// <param name="prompt">Prompt to print to the console.</param>
/// <returns>The int value read, or the default value if unable to parse</returns>
static int ReadInt(int lastUsedValue, string prompt)
{
    Console.Write($"{prompt} [{lastUsedValue}]: ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine($" using value {value}");
        return value;
    }
    else
    {
        Console.WriteLine($" using default value {lastUsedValue}");
        return lastUsedValue;
    }
}

/// <summary>
/// Writes a prompt and reads an double value from the console.
/// </summary>
/// <param name="lastUsedValue">The default value.</param>
/// <param name="prompt">Prompt to print to the console.</param>
/// <returns>The double value read, or the default value if unable to parse</returns>
static double ReadDouble(double lastUsedValue, string prompt)
{
    Console.Write($"{prompt} [{lastUsedValue}]: ");
    if (double.TryParse(Console.ReadLine(), out double value))
    {
        Console.WriteLine($" using value {value}");
        return value;
    }
    else
    {
        Console.WriteLine($" using default value {lastUsedValue}");
        return lastUsedValue;
    }
}