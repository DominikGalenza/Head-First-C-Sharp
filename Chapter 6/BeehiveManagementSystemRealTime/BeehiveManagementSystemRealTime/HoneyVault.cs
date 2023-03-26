using System;

static class HoneyVault
{
    public const float NECTAR_CONVERSION_RATIO = 0.19f;
    public const float LOW_LEVEL_WARNING = 10f;

    private static float honey = 25f;
    private static float nectar = 100f;

    public static string StatusReport 
    {
        get
        {
            if (honey < LOW_LEVEL_WARNING)
            {
                Console.WriteLine("LOW HONEY - ADD A HONEY MANUFACTURER");
            }
            if (nectar < LOW_LEVEL_WARNING)
            {
                Console.WriteLine("LOW NECTAR - ADD A NECTAR MANUFACTURER");
            }
            return $"\nHoney: {honey:0.0} nectar: {nectar:0.0}";
        } 
    }

    public static void ConvertNectarToHoney(float amount)
    {
        if (amount > nectar)
        {
            amount = nectar;
        }

        nectar -= amount;
        honey += amount * NECTAR_CONVERSION_RATIO;
    }

    public static bool ConsumeHoney(float amount)
    {
        if (honey >= amount)
        {
            honey -= amount;
            return true;
        }
        return false;
    }

    public static void CollectNectar(float amount)
    {
        if (amount > 0f)
        {
            nectar += amount;
        }
    }


}