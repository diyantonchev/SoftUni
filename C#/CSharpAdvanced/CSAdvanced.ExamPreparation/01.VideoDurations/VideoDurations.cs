using System;
using System.Linq;

class VideoDurations
{
    static void Main()
    {
        int minutesCounter = 0;
        int hoursCounter = 0;

        string input = Console.ReadLine();
        while (input != "End")
        {
            int[] duration = input.Split(':').Select(int.Parse).ToArray();

            int currentHours = duration[0];
            int currentMinutes = duration[1];

            hoursCounter += currentHours;
            minutesCounter += currentMinutes;

            if (minutesCounter > 59)
            {
                hoursCounter += 1;
                minutesCounter = minutesCounter - 60;
            }
            input = Console.ReadLine();
        }

        string hours = hoursCounter.ToString();
        string minutes = minutesCounter.ToString();
        if (minutes.Length < 2)
        {
            minutes = '0' + minutes;
        }
        Console.WriteLine("{0}:{1}",hours,minutes);
    }
}