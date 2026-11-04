public class Player
{
    Random rnd = new Random();
    public int RollDie()
    {
        return rnd.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rnd.NextDouble() * (100.0 - 0.0) + 0.0;
    }
}
