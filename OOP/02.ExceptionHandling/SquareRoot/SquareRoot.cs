using System;
class SquareRoot
{
    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            double sqrtNumb = Sqrt(number); 
            Console.WriteLine("{0:F4}",sqrtNumb);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }       

    }
    private static double Sqrt(double number)
    {
        if (number < 0)
           throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined","number");
        return Math.Sqrt(number);
    }
}
