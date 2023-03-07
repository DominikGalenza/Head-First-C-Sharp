Guy joe = new Guy() { Name ="Joe", Cash = 50 };
Guy bob = new Guy() { Name = "Bob", Cash = 100 };

while (true)
{
    joe.WriteMyInfo();
    bob.WriteMyInfo();

    Console.Write("Enter an amount: ");
    string howMuch = Console.ReadLine();
    if (howMuch == "") return;

    if (int.TryParse(howMuch, out int amount))
    {
        Console.WriteLine("Who should give the cash: ");
        string whichGuy = Console.ReadLine();
        if (whichGuy == "Joe")
        {
            int givenCash = joe.GiveCash(amount);
            bob.ReceiveCash(givenCash);
        }
        else if (whichGuy == "Bob")
        {
            int givenCash = bob.GiveCash(amount);
            joe.ReceiveCash(givenCash);
        }
        else
        {
            Console.WriteLine("Please enter 'Joe' or 'Bob'");
        }
    }
    else
    {
        Console.WriteLine("Please enter an amount (or a blank line to exit).");
    }
}