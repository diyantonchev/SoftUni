using System;
using System.Collections.Generic;
using System.Text;

class ShoolSystem
{
    static void Main()
    {
        var schoolSystem = new SortedDictionary<string, SortedDictionary<string, double>>();

        var inputRows = int.Parse(Console.ReadLine());
        for (int i = 0; i < inputRows; i++)
        {
            string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = info[0] + ' ' + info[1];
            string subject = info[2];
            double grade = double.Parse(info[3]);
            
            if (!schoolSystem.ContainsKey(name))
            {
                schoolSystem[name] = new SortedDictionary<string, double>();
            }
            if (schoolSystem[name].ContainsKey(subject))
            {
                schoolSystem[name][subject] += grade;
                schoolSystem[name][subject] /= 2;
                if (
                    Math.Abs(Math.Round(schoolSystem[name][subject]) - (schoolSystem[name][subject] + 0.5)) > 0.0005
                    && Math.Abs(Math.Round(schoolSystem[name][subject]) - (schoolSystem[name][subject] - 0.5)) > 0.0005)
                {
                    schoolSystem[name][subject] = Math.Round(schoolSystem[name][subject]);
                }
            }
            else
            {
                schoolSystem[name][subject] = grade;
            }
        }

        var output = new StringBuilder();
        foreach (var student in schoolSystem)
        {
            var currentStudent = new StringBuilder();
            currentStudent.AppendFormat("{0}: [", student.Key);
            foreach (var subject in student.Value)
            {
                currentStudent.AppendFormat("{0} - {1:F2}, ", subject.Key, subject.Value);
            }
            output.AppendFormat("{0}]", currentStudent.ToString().Trim(',', ' ')).AppendLine();
        }
        Console.WriteLine(output.ToString().Trim());
    }
}