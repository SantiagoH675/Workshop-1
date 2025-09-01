using Actividad;

try
{
    var t1 = new Time();
    var t2 = new Time(14);
    var t3 = new Time(9, 34);
    var t4 = new Time(19, 45, 56);
    var t5 = new Time(23, 3, 45, 678);

    var times = new List<Time> { t1, t2, t3, t4, t5 };

    foreach (var time in times)
    {
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"\tMilliseconds: {time.toMillisecond(),15:NO}");
        Console.WriteLine($"\tSeconds     : {time.toSecond(),15:NO}");
        Console.WriteLine($"\tMinutes     : {time.toMinutes(),15:NO}");
        Console.WriteLine($"\t.add        : {time.add(t3),15:NO}");
        Console.WriteLine($"\tIs other day: {time.IsOtherDay(t4)}");
        Console.WriteLine();
    }
    var t6 = new Time(45, -7, 90, -87);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}