using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SchoolSystem
{
    static void Main()
    {
        int inputLinesCount = int.Parse(Console.ReadLine());
        var inputLines = new List<string[]>();

        for (int i = 0; i < inputLinesCount; i++)
        {
            inputLines.Add(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        var studentsPerformance = new SortedDictionary<string, SortedDictionary<string, double>>();

        for (int i = 0; i < inputLines.Count; i++)
        {
            string name = inputLines[i][0] + ' ' + inputLines[i][1];
            string subject = inputLines[i][2];
            double grade = double.Parse(inputLines[i][3]);

            if (!studentsPerformance.ContainsKey(name))
            {
                var subjects = new SortedDictionary<string, double>();
                subjects[subject] = grade;
                studentsPerformance[name] = subjects;
            }
            else
            {
                if (!studentsPerformance[name].ContainsKey(subject))
                {
                    studentsPerformance[name][subject] = grade;
                }
                else
                {
                    List<double> grades = new List<double>();
                    grades.Add(studentsPerformance[name][subject]);
                    grades.Add(grade);
                    double averageGrade = grades.Average();
                    studentsPerformance[name][subject] = averageGrade;
                }
            }
        }
        foreach (var student in studentsPerformance)
        {
            var performance = student.Value.Select(x => x.Key + " - " + x.Value.ToString("0.00")).Aggregate((x, y) => x + ", " + y);
            Console.WriteLine("{0}: [{1}]", student.Key, performance);
        }
    }
    static string lastKey(Dictionary<string,int> dict)
    {
        string lastValue = string.Empty;
        foreach (var item in dict)
        {
            lastValue = item.Value.ToString();
        }
        return lastValue;
    }
}

