using System;
public class Clock : IEquatable<Clock>
{
    private int _myHour;
    private int _myMinute;
    public Clock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;
        while (totalMinutes < 0)
            totalMinutes += 1440;
        int remainedHours = totalMinutes / 60;
        _myMinute = totalMinutes % 60;
        _myHour = remainedHours % 24;
    }
    public override string ToString()
    {
        string MyClock = "";
        if (_myHour < 10)
            MyClock = $"0{_myHour}:";
        else
            MyClock = $"{_myHour}:";
        if (_myMinute < 10)
            MyClock += $"0{_myMinute}";
        else
            MyClock += $"{_myMinute}";
        return MyClock;
    }
    public Clock Add(int minutesToAdd)
    {
        return new Clock(_myHour, _myMinute + minutesToAdd);
    }
    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(_myHour, _myMinute - minutesToSubtract);
    }
    public bool Equals(Clock other)
    {
        return other._myHour == this._myHour &&
            other._myMinute == this._myMinute;
    }
}