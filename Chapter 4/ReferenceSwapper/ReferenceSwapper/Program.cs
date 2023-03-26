Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

void SwapReference()
{
    Console.WriteLine("References have been swapped");

    Elephant swapper;
    swapper = lloyd;
    lloyd = lucinda;
    lucinda = swapper;
}

while (true)
{
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine($"You pressed {value}");

        if (value == 1)
        {
            Console.WriteLine($"Calling lloyd.WhoAmI()");
            lloyd.WhoAmI();
        }
        else if (value == 2)
        {
            Console.WriteLine($"Calling lucinda.WhoAmI()");
            lucinda.WhoAmI();
        }
        else if (value == 3)
        {
            SwapReference();
        }
        else if (value == 4)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
        else if (value == 5)
        {
            lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
        }
        else
        {
            return;
        }
    }
}