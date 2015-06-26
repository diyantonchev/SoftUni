using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers and I will tell you which is bigger: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int max = GetMax(first, second, third);
            Console.WriteLine(max);

        }
        static int GetMax(int a, int b, int c = 0)
        {
            int max = a;
            if (b > a)
            {
                max = b;
            }
            else if (c > b)
            {
                max = c;
            }
            return max;
        }
    }
}
