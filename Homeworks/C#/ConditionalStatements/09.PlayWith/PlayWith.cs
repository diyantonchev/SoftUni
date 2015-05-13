using System;

    class PlayWith
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            string choosen = Console.ReadLine();

            switch (choosen)
            {
                case "1": Console.Write("Please enter a integer: ");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine(integer + 1);
                    break;
                case "2": Console.Write("Please enter a double: ");
                    double doub = double.Parse(Console.ReadLine());
                    Console.WriteLine(doub + 1);
                    break;
                case "3": Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                default: Console.WriteLine("Invalid type.");
                    break;
            }
            
        }
    }
