using System;

public class Time
{
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Time(int minutes, int seconds)
    {
        Minutes = minutes;
        Seconds = seconds;
    }

    public string GetInfo()
    {
        int totalSeconds = Minutes * 60 + Seconds;
        return $"Время: {Minutes} минут {Seconds} секунд ({totalSeconds} секунд всего)";
    }
}

public class MovingTime : Time
{
    public double Speed { get; set; }

    public MovingTime(int minutes, int seconds, double speed) : base(minutes, seconds)
    {
        Speed = speed;
    }

    public double CalculateDistance()
    {
        int totalSeconds = Minutes * 60 + Seconds;
        return totalSeconds * Speed;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Минуты: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Секунды: ");
        int seconds = int.Parse(Console.ReadLine());

        Console.Write("Скорость в м/c: ");
        double speed = double.Parse(Console.ReadLine());

        Time time = new Time(minutes, seconds);
        Console.WriteLine(time.GetInfo());

        MovingTime movingTime = new MovingTime(minutes, seconds, speed);
        Console.WriteLine($"Растояние: {movingTime.CalculateDistance()} метров");
    }
}