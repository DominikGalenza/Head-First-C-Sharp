﻿using System.Diagnostics;

class SwordDamage
{
    public const int BASE_DAMAGE = 3;
    public const int FLAME_DAMAGE = 2;

    public int Roll;
    private decimal magicMultiplier = 1m;
    private int flamingDamage = 0;
    public int Damage;

    public void CalculateDamage()
    {
        Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
        Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
    }

    public void SetMagic(bool isMagic)
    {
        if (isMagic)
        {
            magicMultiplier = 1.75m;
        }
        else
        {
            magicMultiplier = 1m;
        }
        CalculateDamage();
        Debug.WriteLine($"SetMagic finished: {Damage} (roll: {Roll})");
    }

    public void SetFlaming(bool isFlaming)
    {
        CalculateDamage();
        if (isFlaming)
        {
            Damage += FLAME_DAMAGE;
        }
        Debug.WriteLine($"SetFlaming finished: {Damage} (roll: {Roll})");
    }
}