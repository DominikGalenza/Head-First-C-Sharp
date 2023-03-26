using System;

class Queen : Bee
{
    public string StatusReport { get; private set; }
    public override float CostPerShift
    {
        get
        {
            return 2.15f;
        }
    }

    private const float EGGS_PER_SHIFT = 0.45f;
    private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;
    private Bee[] workers = new Bee[0];
    private float eggs;
    private float unassignedWorkers = 3;
    

    public Queen() : base("Queen")
    {
        AssingBee("Egg Care");
        AssingBee("Nectar Collector");
        AssingBee("Honey Manufacturer");
    }

    private void AddWorker(Bee worker)
    {
        if (unassignedWorkers >= 1)
        {
            unassignedWorkers--;
            Array.Resize(ref workers, workers.Length + 1);
            workers[workers.Length - 1] = worker;
        }
    }

    public void AssingBee(string job)
    {
        switch (job)
        {
            case "Egg Care":
            {
                AddWorker(new EggCare(this));
                break;
            }
            case "Nectar Collector":
            {
                AddWorker(new NectarCollector());
                break;
            }
            case "Honey Manufacturer":
            {
                AddWorker(new HoneyManufacturer());
                break;
            }
        }
        
        UpdateStatusReport();
    }

    protected override void DoJob()
    {
        eggs += EGGS_PER_SHIFT;

        foreach (Bee worker in workers)
        {
            worker.WorkTheNextShift();
        }

        HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * unassignedWorkers);

        UpdateStatusReport();
    }

    public void CareForEggs(float eggsToConvert)
    {
        if (eggs >= eggsToConvert)
        {
            eggs -= eggsToConvert;
            unassignedWorkers += eggsToConvert;
        }
    }

    private void UpdateStatusReport()
    {
        StatusReport = $"Vault report: {HoneyVault.StatusReport} \nEgg count: {eggs:0.0} Unassigned workers: {unassignedWorkers:0.0}" +
            $"\n{WorkerStatus("Nectar Collector")} {WorkerStatus("Honey Manufacturer")} {WorkerStatus("Egg Care")} \nTotal workers: {workers.Length}";
    }

    private string WorkerStatus(string job)
    {
        int count = 0;

        foreach (Bee worker in workers)
        {
            if (worker.Job == job)
            {
                count++;
            }
        }

        string s = "s";
        
        if (count == 0)
        {
            s = "";
        }

        return $"{count} {job} bee{s}";
    }
}