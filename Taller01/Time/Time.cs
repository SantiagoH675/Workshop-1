namespace Time;

public class Time
{
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;



    public Time(int hour, int millisecond, int minute, int second)
    {

        Hour = hour;
        Millisecond = millisecond;
        Minute = minute;
        Second = second;
    }

    public int Hour
    {
        get => _hour;
        set
        {
            _hour = ValidHour(value);
        }
    }

    public int Millisecond
    {
        get => _millisecond;
        set
        {
            _millisecond = ValidMillisecond(value);
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            _minute = ValidMinute(value);
        }
    }
    public int Second
    {
        get => _second;
        set
        {
            _second = ValidSecond(value);
        }
    }

    private int ValidHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception("Hour must be between 0 and 23.");
        }
        return hour;
    }
    private int ValidMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception("Millisecond must be between 0 and 999.");
        }
        return millisecond;
    }
    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception("Minute must be between 0 and 59.");
        }
        return minute;
    }
    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception("Second must be between 0 and 59.");
        }
        return second;

    }
}
