using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VLadkosNotebook
{
    static void Main()
    {
        string entry = Console.ReadLine();

        var vladkosNotebook = new SortedDictionary<string, Player>();
        while (entry != "END")
        {
            string[] data = entry.Split('|');
            string color = data[0];
            if (!vladkosNotebook.ContainsKey(color))
            {
                vladkosNotebook[color] = new Player();
                vladkosNotebook[color].Opponents = new List<string>();
            }

            Player currentPlayer = vladkosNotebook[color];
            if (data[1] == "age")
            {
                int age = int.Parse(data[2]);
                currentPlayer.Age = age;
            }
            else if (data[1] == "loss")
            {
                currentPlayer.LossCount += 1;
                currentPlayer.Opponents.Add(data[2]);
            }
            else if (data[1] == "win")
            {
                currentPlayer.WinCount += 1;
                currentPlayer.Opponents.Add(data[2]);
            }
            else if (data[1] == "name")
            {
                string name = data[2];
                currentPlayer.Name = name; 
            }
                      
           entry = Console.ReadLine();
        }
        var validPages = vladkosNotebook
                 .Where(page => page.Value.Age != 0 && page.Value.Name != null);

        if (validPages.Count() == 0)
        {
            Console.WriteLine("No data recovered.");
            return;
        }

        var output = new StringBuilder();
        foreach (var page in validPages)
        {
            output.AppendLine(string.Format("Color: {0}", page.Key));
            output.AppendLine(string.Format("-age: {0}",page.Value.Age));
            output.AppendLine(string.Format("-name: {0}", page.Value.Name));

            if (page.Value.Opponents.Count > 0)
            {
                 var sortedOpponents = page.Value.Opponents.OrderBy(o => o, StringComparer.Ordinal);
                 output.AppendLine(string.Format("-opponents: {0}", string.Join(", ", sortedOpponents)));
            }
            else
            {
                output.AppendLine(string.Format("-opponents: (empty)"));
            }

            double rank = (double)(page.Value.WinCount + 1) / (page.Value.LossCount + 1);

            output.AppendLine(string.Format("-rank: {0:F2}", rank));
        }
        Console.WriteLine(output.ToString());
    }
}
class Player 
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<string> Opponents { get; set; }

    public int WinCount { get; set; }

    public int LossCount { get; set; }
}

