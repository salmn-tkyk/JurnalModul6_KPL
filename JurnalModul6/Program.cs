class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Salman");

        for (int i = 1; i <= 10; i++)
        {
            user.AddVideo(new SayaTubeVideo($"Review Film Judul {i} oleh Salman"));
        }
        user.PrintAllVideoPlaycount();

        SayaTubeVideo v = new SayaTubeVideo("Test Overflow");
        try
        {
            for (int i = 0; i < 100; i++) { v.IncreasePlayCount(25000000); }
        }
        catch { }
    }
}