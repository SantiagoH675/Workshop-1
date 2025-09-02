namespace Actividad;

public class Time
{
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;


    /*public Time()
    {

        Hour = 0;
        Millisecond = 0;
        Minute = 0;
        Second = 0;
    }*/

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
    public Time(int hour): this(hour, 0, 0, 0) { }
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }
    public Time(int hour = 0, int minute = 0, int second = 0, int millisecond = 0)
    {
        Hour = hour;
        Millisecond = millisecond;
        Minute = minute;
        Second = second;

    }
    public long ToMilliseconds()
        => ((long)Hour * 3600 + (long)Minute * 60 + (long)Second) * 1000 + Millisecond;
    public long ToSeconds()
        => ((long)Hour * 3600 + (long)Minute * 60 + (long)Second);
    public long ToMinutes()
        => ((long)Hour * 60 + (long)Minute);
    public object add(Time other)
    {
        long totalMilliseconds = ToMilliseconds() + other.ToMilliseconds();
    }


    /*public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }*/
    public bool IsOtherDay(Time t4)
    {
        throw new NotImplementedException();
    }

    public object ToMillisecond()
    {
        throw new NotImplementedException();
    }

    public object ToMinutes()
    {
        throw new NotImplementedException();
    }

    public object ToSecond()
    {
        throw new NotImplementedException();
    }

    private int ValidHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception($"Hour:{hour} must be between 0 and 23.");
        }
        return hour;
    }
    private int ValidMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception($"Millisecond:{millisecond} must be between 0 and 999.");
        }
        return millisecond;
    }
    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception($"Minute: {minute} must be between 0 and 59.");
        }
        return minute;
    }
    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception($"Second: {second} must be between 0 and 59.");
        }
        return second;

    }
}
