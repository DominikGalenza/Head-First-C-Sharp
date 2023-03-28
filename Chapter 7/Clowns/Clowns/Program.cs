IClown fingersTheClown = new ScaryScary("big red nose", 14);
fingersTheClown.Honk();
if (fingersTheClown is IScaryClown iScaryClownReference)
{
    iScaryClownReference.ScareLittleChildren();
}