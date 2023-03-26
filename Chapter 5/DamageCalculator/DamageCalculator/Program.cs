﻿SwordDamage swordDamage = new SwordDamage();
Random random = new Random();

while (true)
{
    Console.WriteLine("Choose the sword type: 0 for no magic or flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit.");
    char key = Console.ReadKey().KeyChar;

    if (!(key == '0' || key == '1' || key == '2' || key == '3'))
    {
        return;
    }

    swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

    if (key == '0')
    {
        swordDamage.CalculateDamage();
    }

    swordDamage.SetMagic(key == '1' || key == '3');
    swordDamage.SetFlaming(key == '2' || key == '3');

    Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
}