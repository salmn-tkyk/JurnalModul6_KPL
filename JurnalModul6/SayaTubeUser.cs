using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class SayaTubeUser
{
    public string Username { get; private set; }
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < Math.Min(uploadedVideos.Count, 10); i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].title}");
        }
    }
}
