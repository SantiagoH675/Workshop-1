namespace Actividad;

public class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    public Time()
    {

        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }
    public Time(int hour) : this(hour, 0, 0, 0) { }
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }
    public Time(int hour,int minute,int second,int millisecond)
    {
        
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
         
    }
    public int Hour
    {
        get => _hour;
        set
        {
            _hour = ValidHour(value);
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
  
    public int Millisecond
    {
        get => _millisecond;
        set
        {
            _millisecond = ValidMillisecond(value);
        }
    }

    public long ToMilliseconds()
    {
        return (long)Hour * 3600000 + (long)Minute * 60000 + (long)Second * 1000 + Millisecond;
    }
        
    public long ToSeconds()
    {
        return ToMilliseconds() / 1000;
    }
        
    public long ToMinutes()
    {
        return ToMilliseconds() / 60000;
    }
        
    public Time Add(Time other)
    {
        long totalMilliseconds = ToMilliseconds() + other.ToMilliseconds();
        int  New_hour  = (int)((totalMilliseconds / 3600000) % 24);
        int  New_minute  = (int)((totalMilliseconds / 60000) % 60);
        int  New_second  = (int)((totalMilliseconds / 1000) % 60);
        int  New_milliseconds  = (int) (totalMilliseconds % 1000);

        return new Time(New_hour, New_minute, New_second, New_milliseconds);
    }
    public bool IsOtherDay(Time other)
    {
        return ToMilliseconds() + other.ToMilliseconds() >= 86400000;
    }
    
   public override string ToString()
    {
        if (Hour == 0 && Minute == 0 && Second == 0 && Millisecond == 0)
        {
            return "00:00:00.000 AM";
        }

        int displayHour = Hour % 12;
        if (displayHour == 0) displayHour = 12; 

        string amPm = Hour < 12 ? "AM" : "PM";

        return $"{displayHour:00}:{Minute:00}:{Second:00}.{Millisecond:000} {amPm}";

    }
    
    private int ValidHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception($"the hour:{hour} is not valid");
        }
        return hour;
    }
    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception($"the Minute: {minute} is not valid.");
        }
        return minute;
    }
    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception($"The Second: {second} is not valid");
        }
        return second;

    }
    private int ValidMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception($"The Millisecond:{millisecond} is not valid.");
        }
        return millisecond;
    }

}
