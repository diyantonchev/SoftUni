using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class GandalfsStash
{
    static void Main()
    {
        var foods = new Dictionary<string, int>()
                        {
                            {"cram", 2},
                            {"lembas", 3},
                            {"apple",1},
                            {"melon",1},
                            {"honeycake",5},
                            {"mushrooms",-10}
                        };

        int gandalfsMood = int.Parse(Console.ReadLine());
        string[] listOfFoods = Regex.Split(Console.ReadLine().Trim(), @"[^A-Za-z]+");

        foreach (var food in listOfFoods.Where(food => !string.IsNullOrWhiteSpace(food)))
        {
            if (foods.ContainsKey(food.ToLower()))
            {
                gandalfsMood += foods[food.ToLower()];
            }
            else
            {
                gandalfsMood -= 1;
            }
        }

        Console.WriteLine(gandalfsMood);

        if (gandalfsMood < -5)
        {
            Console.WriteLine("Angry");
        }
        else if (gandalfsMood >= -5 && gandalfsMood < 0)
        {
            Console.WriteLine("Sad");
        }
        else if (gandalfsMood > 0 && gandalfsMood < 15)
        {
            Console.WriteLine("Happy");
        }
        else if (gandalfsMood > 15)
        {
            Console.WriteLine("Special JavaScript mood");
        }
    }
}