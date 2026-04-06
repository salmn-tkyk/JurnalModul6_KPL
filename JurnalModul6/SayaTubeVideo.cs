using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class SayaTubeVideo
{
    public int id { get; private set; }
    public string title { get; private set; }
    public int playCount { get; private set; }

    public SayaTubeVideo(string title)
    {
        this.title = title;
        this.id = new Random().Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id} | Title: {title} | Plays: {playCount}");
    }
}