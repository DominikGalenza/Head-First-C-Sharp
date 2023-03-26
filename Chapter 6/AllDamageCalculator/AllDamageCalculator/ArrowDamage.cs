class ArrowDamage : WeaponDamage
{
    private const decimal BASE_MULTIPLIER = 0.35m;
    private const decimal FLAME_DAMAGE = 1.25m;
    private const decimal MAGIC_MULTIPLIER = 2.5m;

    /// <summary>
    /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
    /// </summary>
    /// <param name="startingRoll">Starting 3d6 roll</param>
    public ArrowDamage(int startingRoll) : base(startingRoll)
    {

    }

    /// <summary>
    /// Calculates the damage based on the current properties.
    /// </summary>
    protected override void CalculateDamage()
    {
        decimal baseDamage = Roll * BASE_MULTIPLIER;

        if (Magic)
        {
            baseDamage *= MAGIC_MULTIPLIER;
        }

        if (Flaming)
        {
            Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
        }
        else
        {
            Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}