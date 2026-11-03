static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0){
            return 0;
        }

        if (speed <= 4) {
            return 1;
        }

        if (speed <= 8) {
            return 0.90;
        }

        if (speed == 9) {
            return 0.80;
        }
        
        return 0.77;
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var itemsPerMinute = (speed * 221 / 60d) * SuccessRate(speed);
        return (int)(itemsPerMinute);
    }
}