class Lasagna
{

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutes)
    {
        return ExpectedMinutesInOven() - minutes;
    }

    public int PreparationTimeInMinutes(int numberOfCapes)
    {
        return numberOfCapes * 2;
    }

    public int ElapsedTimeInMinutes(int numberOfCapes, int minutes)
    {
        return PreparationTimeInMinutes(numberOfCapes) + minutes;
    }
    
}
