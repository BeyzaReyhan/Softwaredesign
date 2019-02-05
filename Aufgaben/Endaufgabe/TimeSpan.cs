using System;

public struct TimeSpan
{
    public DateTime startZeit;
    public DateTime endZeit;

    public TimeSpan(DateTime start, DateTime ende) 
    {
        this.startZeit = start;
        this.endZeit = ende;
    }
}