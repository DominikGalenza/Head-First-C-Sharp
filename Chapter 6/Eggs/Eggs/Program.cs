﻿while (true)
{
    Bird bird;
    Console.WriteLine("Press P for pigeon, O for ostrich: ");

    char key = char.ToUpper(Console.ReadKey().KeyChar);
    if (key == 'P')
    {
        bird = new Pigeon();
    }
    else if (key == 'O')
    {
        bird = new Ostrich();
    }
    else
    {
        return;
    }

    Console.WriteLine("\nHow many eggs should it lay? ");
    if (!int.TryParse(Console.ReadLine(), out int numberOfEggs))
    {
        return;
    }

    Egg[] eggs = bird.LayEggs(numberOfEggs);
    foreach (Egg egg in eggs)
    {
        Console.WriteLine(egg.Description);
    }
}