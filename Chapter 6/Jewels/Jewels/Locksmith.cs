class Locksmith
{
    public string Combination { private get; set; }

    public void OpenSafe(Safe safe, SafeOwner safeOwner)
    {
        safe.PickLock(this);
        string safeContents = safe.Open(Combination);
        ReturnContents(safeContents, safeOwner);
    }

    protected virtual void ReturnContents(string safeContents, SafeOwner safeOwner)
    {
        safeOwner.ReceiveContents(safeContents);
    }
}