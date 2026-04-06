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
        Debug.Assert(title != null && title.Length <= 200);
        this.title = title;
        this.id = new Random().Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count >= 0 && count <= 25000000);
        try
        {
            checked { this.playCount += count; }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: PlayCount melebihi batas integer!");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id} | Title: {title} | Plays: {playCount}");
    }
}