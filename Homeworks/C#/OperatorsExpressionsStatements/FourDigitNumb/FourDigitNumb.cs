using System;

    class FourDigitNumb
    {
        static void Main()
        {
            int n = 1234;

            int firstDigit = n / 1000;

            int secondDigit = (n / 100) % 10;

            int thirdDigit = (n / 10) % 10;

            int fourthDigit = (n % 10);

            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        
            Console.WriteLine("Four-digit number --> " + n);
            Console.WriteLine("Sum of digits = " + sumOfDigits);

            Console.WriteLine("Reversed --> " + "{0}{1}{2}{3}",
                fourthDigit, thirdDigit, secondDigit, firstDigit);

            Console.WriteLine("Last digit in front --> " + "{0}{1}{2}{3}", 
                fourthDigit, firstDigit, secondDigit, thirdDigit);

            Console.WriteLine("Second and third digits exchanged --> " + "{0}{1}{2}{3}",
                firstDigit, thirdDigit, secondDigit, fourthDigit);


            
           
        }
    }

