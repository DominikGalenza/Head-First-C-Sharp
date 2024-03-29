﻿class HoneyManufacturer : Bee
{
    public override float CostPerShift
    {
        get
        {
            return 1.7f;
        }
    }

    private const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;

    public HoneyManufacturer() : base("Honey Manufacturer")
    {

    }

    protected override void DoJob()
    {
        HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
    }
}