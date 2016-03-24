using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        //Console.WriteLine(DateTime.Parse("10:30PM"));
        int hours = int.Parse(Console.ReadLine());
        int minutes= int.Parse(Console.ReadLine());
        string format = Console.ReadLine();
        string time = hours + ":"+ minutes + format;

        DateTime startHour = DateTime.Parse(time);
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes= int.Parse(Console.ReadLine());
        startHour=startHour.AddHours(durationHours);
        startHour=startHour.AddMinutes(durationMinutes);

        Console.WriteLine(startHour.ToString("hh:mm:tt", CultureInfo.InvariantCulture));

    }
}