using System;

class Arrays
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];

        Random random = new Random();
        //string input = "0 1 2 3 4 5 6 7 8 9";
        //string[] numbers = input.Split(' ');

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 101);

            Console.Write(arr[i] + " ");

            if (i > 0)
            {
                arr[i] += arr[i - 1];
            }

            Console.WriteLine(arr[i] + " ");
        }
    }
}

