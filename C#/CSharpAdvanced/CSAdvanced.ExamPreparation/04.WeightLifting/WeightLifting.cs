using System;
using System.Collections.Generic;
using System.Text;

class WeightLifting
{
    static void Main()
    {
        var playersPerformance = new SortedDictionary<string,SortedDictionary<string,double>>();
     
        int inputLinesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < inputLinesCount; i++)
        {
            var exercisesForToday = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            string player = exercisesForToday[0];
            string typeOfExercise = exercisesForToday[1];
            double weight = double.Parse(exercisesForToday[2]);

            if (!playersPerformance.ContainsKey(player))
            {
                playersPerformance[player] = new SortedDictionary<string, double>();
            }
            if (playersPerformance[player].ContainsKey(typeOfExercise))
            {
                playersPerformance[player][typeOfExercise] += weight;
            }
            else
            {
                playersPerformance[player][typeOfExercise] = weight;
            }
        }

        foreach (var player in playersPerformance)
        {
            Console.Write("{0} : ", player.Key);         
            var exercises = new StringBuilder();
            foreach (var exercise in player.Value)
            {
              exercises.Append(string.Format("{0} - {1} kg, ",exercise.Key,exercise.Value));
            }
            Console.WriteLine(exercises.ToString().Trim(',', ' '));
        }
    }
}