﻿IClown.CarCapacity = 18;
Console.WriteLine(IClown.ClownCarDescription());

IClown fingersTheClown = new ScaryScary("big red nose", 14);
fingersTheClown.Honk();
if (fingersTheClown is IScaryClown iScaryClownReference)
{
    iScaryClownReference.ScareAdults();
}