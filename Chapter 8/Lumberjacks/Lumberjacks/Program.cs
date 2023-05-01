Random random = new Random();
Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
string lumberjacksName;

Console.WriteLine("Name the first lumberjack:");
while ((lumberjacksName = Console.ReadLine()) != "")
{
    Console.WriteLine("Enter number of flapjacks for the lumberjack:");
    if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
    {
        Lumberjack lumberjack = new Lumberjack(lumberjacksName);
        for (int i = 0; i < numberOfFlapjacks; i++)
        {
            lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
        }
        lumberjacks.Enqueue(lumberjack);
    }
    Console.WriteLine("Next lumberjack's name (blank to end):");
}

while (lumberjacks.Count > 0)
{
    Lumberjack nextLumberjack = lumberjacks.Dequeue();
    nextLumberjack.EatFlapjacks();
}