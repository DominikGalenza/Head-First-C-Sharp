class JewelThief : Locksmith
{
    private string stolenJewels;

    protected override void ReturnContents(string safeContents, SafeOwner safeOwner)
    {
        stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole {stolenJewels}");
    }
}