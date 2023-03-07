double odds = 0.75d;
Random random = new Random();
Guy player = new Guy() { Name = "The player", Cash = 100 };

Console.WriteLine($"Welcome to the casino. The odds are {odds}");

while (player.Cash > 0)
{
    player.WriteMyInfo();
    Console.WriteLine("How much do you want to bet: ");
    string howMuch = Console.ReadLine();  

    if (int.TryParse(howMuch, out int amount))
    {
        int pot = player.GiveCash(amount) * 2;

        if (pot > 0)
        {
            double randomNumber = random.NextDouble();

            if (randomNumber > odds)
            {
                Console.WriteLine($"You win {pot}");
                player.ReceiveCash(pot);
            }
            else
            {
                Console.WriteLine("You lose, bad luck.");
            }
        } 
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }   
}
Console.WriteLine("The casino always wins.");