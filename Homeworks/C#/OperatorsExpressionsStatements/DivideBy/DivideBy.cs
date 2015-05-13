using System;

namespace DivideBy
{
    class DivideBy
    {
        static void Main(string[] args)
        {
            int n = 35; //true
            //int n = 30; //false

            bool check = (n % 7 == 0) && (n % 5 == 0);
            Console.WriteLine(check );
        }
    }
}
