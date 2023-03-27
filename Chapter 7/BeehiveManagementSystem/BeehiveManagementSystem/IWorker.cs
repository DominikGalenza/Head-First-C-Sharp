interface IWorker
{
    string Job { get; }
    void WorkTheNextShift();
}