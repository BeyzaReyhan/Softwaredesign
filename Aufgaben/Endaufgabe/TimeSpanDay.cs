using System;

public struct TimeSpanDay
{
    public DateTime startZeit;
    public DateTime endZeit;
    public DayEnum tag;

    public TimeSpanDay(DateTime start, DateTime ende, DayEnum tag) 
    {
        this.startZeit = start;
        this.endZeit = ende;
        this.tag = tag;
    }
}