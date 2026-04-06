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
    }
}