using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CategorizeNumbers
{
    class Categorize
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] numbers = input.Select(double.Parse).ToArray();

            List<double> floatNumbers = new List<double>();
            List<double> roundNumbers = new List<double>();

            foreach (var number in numbers)
            {
                if (number % 1 == 0)
                {
                    roundNumbers.Add(number);
                }
                else
                {
                    floatNumbers.Add(number);
                }
            }

            Console.WriteLine("[{0}] -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}",
                string.Join(" ", floatNumbers),
                floatNumbers.Min(),floatNumbers.Max(),
                floatNumbers.Sum(),floatNumbers.Average());

            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4}",
                string.Join(" ", roundNumbers),
                roundNumbers.Min(),roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
        }
    }
}
