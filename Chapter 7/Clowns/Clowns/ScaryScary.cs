class ScaryScary : FunnyFunny, IScaryClown
{
    public string ScaryThingIHave
    {
        get
        {
            return $"{scaryThingCount} spiders";
        }
    }

    private readonly int scaryThingCount;

    public ScaryScary(string funnyThingIHave, int scaryThingCount) : base(funnyThingIHave)
    {
        this.scaryThingCount = scaryThingCount;
    }

    public void ScareLittleChildren()
    {
        Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
    }
}