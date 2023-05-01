class RetiredPlayer
{
    public string Name { get; set; }
    public int YearRetired { get; set; }

    public RetiredPlayer(string player, int yearRetired)
    {
        Name = player;
        YearRetired = yearRetired;
    }
}