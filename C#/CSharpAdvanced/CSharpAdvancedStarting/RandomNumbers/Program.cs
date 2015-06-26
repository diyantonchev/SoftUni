using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumbers;
            for (int i = 0; i < 10; i++)
            {
                randomNumbers = random.Next(100, 201);
                Console.WriteLine(randomNumbers);
            }
        }
    }
}
