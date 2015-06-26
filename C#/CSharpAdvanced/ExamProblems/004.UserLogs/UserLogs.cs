using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogs
{
    static void Main()
    {
        var output = new SortedDictionary<string, Dictionary<string, int>>();

        string inputMessage = Console.ReadLine();
        while (inputMessage != "end")
        {
            string[] message = inputMessage.Split();

            string[] adressIPInput = message[0].Split('=');
            string adressIP = adressIPInput[1];
            string userInput = message[2];
            string[] user = userInput.Split('=');
            string username = user[1];

            if (!output.ContainsKey(username))
            {
                var currentUser = new Dictionary<string, int>();
                currentUser[adressIP] = 1;
                output[username] = currentUser;
            }
            else
            {
                if (!output[username].ContainsKey(adressIP))
                {
                    output[username][adressIP] = 1;
                }
                else
                {
                    output[username][adressIP] += 1;
                }
            }

            inputMessage = Console.ReadLine();
        }

        var currentCouple = new Dictionary<string, int>();

        foreach (var user in output)
        {
            currentCouple = user.Value;
            Console.WriteLine("{0}: ", user.Key);
            foreach (var ip in user.Value)
            {
                if (!ip.Key.Equals(GetLastKey(currentCouple)))
                {
                    Console.Write("{0} => {1}, ", ip.Key, ip.Value);
                }
                else
                {
                    Console.Write("{0} => {1}.", ip.Key, ip.Value);
                }
            }
            Console.WriteLine();
        }
    }

    static string GetLastKey(Dictionary<string, int> dict)
    {
        string lastKey = string.Empty;
        foreach (var couple in dict)
        {
            lastKey = couple.Key;
        }
        return lastKey;
    }
}
