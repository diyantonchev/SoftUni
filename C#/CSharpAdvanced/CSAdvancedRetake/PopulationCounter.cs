using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PopulationCounter
{
    static void Main()
    {
        var populationCounter = new Dictionary<string,List<City>>();

        string input = Console.ReadLine();
        while (input != "report")
        {
            string[] data = input.Split('|');

            string country = data[1];
            string city = data[0];
            double population = double.Parse(data[2]);
           
            var currentCity = new City(city,population);
            if (!populationCounter.ContainsKey(country))
            {
                populationCounter[country] = new List<City>() ;
            }

            if (!populationCounter[country].Contains(currentCity))
            {
                populationCounter[country].Add(currentCity);
                
            }
            
            input = Console.ReadLine();
        }

        var orderedData = populationCounter.OrderByDescending(c =>  c.Value.Sum(x => x.Population));

        var output = new StringBuilder();  
        foreach (var pair in orderedData)
        {
            output.AppendFormat("{0} (total population: {1})",
                pair.Key, pair.Value.Sum(x => x.Population)).AppendLine();
            foreach (var city in pair.Value.OrderByDescending(c => c.Population))
            {
               output.AppendLine(string.Format("=>{0}: {1}",city.Name,city.Population));
            }
        }

        Console.WriteLine(output.ToString().Trim());
    }
}

public class City 
{
    public City(string name, double population)
    {
        this.Name = name;
        this.Population = population;
    }

    public string Name { get; set; }

    public double Population { get; set; }
}