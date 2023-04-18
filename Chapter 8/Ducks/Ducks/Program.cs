List<Duck> ducks = new List<Duck>()
{
    new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
    new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
    new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
    new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
    new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
    new Duck() { Kind = KindOfDuck.Loon, Size = 13 }
};
IComparer<Duck> sizeComparer = new DuckComparerBySize();
IComparer<Duck> kindComparer = new DuckComparerByKind();
DuckComparer comparer = new DuckComparer();

static void PrintDucks(List<Duck> ducks)
{
    foreach (Duck duck in ducks)
    {
        Console.WriteLine($"{duck.Size} inch {duck.Kind}");
    }
}

ducks.Sort(sizeComparer);
PrintDucks(ducks);
ducks.Sort(kindComparer);
PrintDucks(ducks);

Console.WriteLine("\nSorting by kind then size\n");
comparer.SortBy = SortCriteria.KindThenSize;
ducks.Sort(comparer);
PrintDucks(ducks);

Console.WriteLine("\nSorting by size then kind\n");
comparer.SortBy = SortCriteria.SizeThenKind;
ducks.Sort(comparer);
PrintDucks(ducks);