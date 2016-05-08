using System;
using System.Collections.Generic;

    class Phonebook
    {
        static void Main()
        {
            Dictionary<string,string> contacts = new Dictionary<string,string>();

            
            while (true)
            {
                string input = Console.ReadLine();  
                if (input == "search" )
                {
                    break;   
                }
                string[] contact = input.Split('-');
                contacts.Add(contact[0], contact[1]);          
            }

            Console.WriteLine();
            while (true)
            {
                try
                {
                    string name = Console.ReadLine();
                    if (contacts.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, contacts[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                catch (Exception)
                {

                    break;
                }
            }
            
        }
    }

