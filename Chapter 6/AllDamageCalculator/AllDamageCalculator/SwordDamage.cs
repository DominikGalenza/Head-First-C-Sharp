class SwordDamage : WeaponDamage
{
    private const int BASE_DAMAGE = 3;
    private const int FLAME_DAMAGE = 2;

    /// <summary>
    /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
    /// </summary>
    /// <param name="startingRoll">Starting 3d6 roll</param>
    public SwordDamage(int startingRoll) : base(startingRoll)
    {

    }

    /// <summary>
    /// Calculates the damage based on the current properties.
    /// </summary>
    protected override void CalculateDamage()
    {
        decimal magicMultiplier = 1m;

        if (Magic)
        {
            magicMultiplier = 1.75m;
        }

        Damage = BASE_DAMAGE;
        Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

        if (Flaming)
        {
            Damage += FLAME_DAMAGE;
        }
    }
}