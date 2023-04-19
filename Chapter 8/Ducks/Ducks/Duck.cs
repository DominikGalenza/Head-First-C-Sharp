class Duck : IComparable<Duck>
{
    public int Size { get; set; }
    public KindOfDuck Kind { get; set; }

    public override string ToString()
    {
        return $"A {Size} inch {Kind}";
    }

    public int CompareTo(Duck duckToCompare)
    {
        if (Size > duckToCompare.Size)
        {
            return 1;
        }
        else if (Size < duckToCompare.Size)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}