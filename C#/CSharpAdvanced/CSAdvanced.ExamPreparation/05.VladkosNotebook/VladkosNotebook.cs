using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VladkosNotebook
{
    static void Main()
    {
        var prettyNotebook = new SortedDictionary<string, Player>();

        string input = Console.ReadLine();


        while (input != "END")
        {
            string[] info = input
            .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string color = info[0];

            if (!prettyNotebook.ContainsKey(color))
            {
                prettyNotebook[color] = new Player();
            }

            switch (info[1])
            {
                case "win":
                    prettyNotebook[color].Wins++;
                    prettyNotebook[color].Opponents.Add(info[2]);
                    break;
                case "loss":
                    prettyNotebook[color].Losses++;
                    prettyNotebook[color].Opponents.Add(info[2]);
                    break;
                case "age":
                    prettyNotebook[color].Age = int.Parse(info[2]);
                    break;
                case "name":
                    prettyNotebook[color].Name = info[2];
                    break;
            }
            input = Console.ReadLine();
        }

        if (prettyNotebook.Values.All(p => p.Age == 0 || p.Name == null))
        {
            Console.WriteLine("No data recovered.");
            return;
        }

        foreach (var sheet in prettyNotebook.Where(sheet => !(sheet.Value.Age == 0 || string.IsNullOrWhiteSpace(sheet.Value.Name))))
        {
            Console.WriteLine("Color: {0}", sheet.Key);
            Console.WriteLine(sheet.Value);
        }
    }
}

public class Player
{
    public Player()
    {
        this.Opponents = new List<string>();
    }

    public int Age { get; set; }

    public int Wins { get; set; }

    public int Losses { get; set; }

    public string Name { get; set; }

    public List<string> Opponents { get; set; }

    public double Rank
    {
        get
        {
            return CalculateRank(this.Wins, this.Losses);

        }
    }

    private static double CalculateRank(int wins, int losses)
    {
        double rank = (double)(wins + 1) / (losses + 1);

        return rank;
    }

    public override string ToString()
    {
        var player = new StringBuilder();
     
        player.AppendLine(string.Format("-age: {0}", this.Age));
        player.AppendLine(string.Format("-name: {0}", this.Name));

        this.Opponents.Sort(StringComparer.Ordinal);
        
        player.AppendLine(
            this.Opponents.Any()
                ? string.Format("-opponents: {0}", string.Join(", ", this.Opponents))
                : "-opponents: (empty)");

        player.Append(string.Format("-rank: {0:F2}", this.Rank));

        return player.ToString();
    }
}