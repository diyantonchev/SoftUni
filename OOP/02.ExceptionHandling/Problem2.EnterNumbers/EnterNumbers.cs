using System;
using System.Collections.Generic;

class EnterNumbers
{
    static void Main()
    {
        var numbers = new List<int>();

        Console.WriteLine("Insert 10 numbers:");
        while (numbers.Count < 10)
        {
            numbers.Add(ReadNumber(1, 100));
        }
        Console.WriteLine("Thank you!");

        Console.WriteLine("Your numbers: [{0}]", string.Join(", ", numbers));
    }
    static int ReadNumber(int start, int end)
    {
        int number;

        while (true)
        {
            try
            {
                number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The input number must be in range [1 ... 100]");
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid number.", fe.Message);
            }
            catch (OverflowException ovex)
            {
                Console.WriteLine(ovex.Message);
            }
        }
    }
}