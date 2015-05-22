using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndEncrypt
{
    class EncodeAndEncrypt
    {
        static void Main()
        {
            string message = Console.ReadLine().ToUpper();
            string cypher = Console.ReadLine().ToUpper();

            int lengthOfCypher = cypher.Length;

            string finalResult = Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher;
            Console.WriteLine(finalResult);
        }
        static string Encrypt(string message, string cypher)
        {
            string cypherText = string.Empty;

            if (message.Length > cypher.Length)
            {
                cypherText = EncryptWhenMessageIsLonger(message, cypher);

            }
            else
            {
                cypherText = EncryptWhenCypherIsLonger(message, cypher);
            }
            return cypherText;
        }
        static string EncryptWhenMessageIsLonger(string message, string cypher)
        {
            var result = new StringBuilder();

            int cypherIndex = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char messageSymbol = message[i];
                char cypherSymbol = cypher[cypherIndex];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result.Append(encryptedSymbol);

                cypherIndex++;
                if (cypherIndex == cypher.Length)
                {
                    cypherIndex = 0;
                }
            }
            return result.ToString();
        }

        static string EncryptWhenCypherIsLonger(string message, string cypher)
        {
            var result = new StringBuilder(message);

            int messageIndex = 0;
            for (int i = 0; i < cypher.Length; i++)
            {
                char cypherSymbol = cypher[i];
                char messageSymbol = result[messageIndex];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result[messageIndex] = encryptedSymbol;

                messageIndex++;
                if (messageIndex == message.Length)
                {
                    messageIndex = 0;
                }
            }

            return result.ToString();
        }
        static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();

            char prevSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == prevSymbol)
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        result.Append(prevSymbol);
                    }
                    else if (counter == 2)
                    {
                        result.Append(new string(prevSymbol, 2));   
                    }
                    else
                    {
                        result.Append(counter.ToString()+ prevSymbol);
                    }
                    counter = 1;
                }
                prevSymbol = text[i];
            }
            if (counter == 1)
            {
                result.Append(prevSymbol);
            }
            else if (counter == 2)
            {
                result.Append(new string(prevSymbol, 2));
            }
            else
            {
                result.Append(counter.ToString() + prevSymbol);
            }

            return result.ToString();  
        }
        static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int messageSymbolCode = messageSymbol - 'A';
            int cypherSymbolCode = cypherSymbol - 'A';

            int resultingCode = messageSymbolCode ^ cypherSymbolCode;
            char newCode = (char)(resultingCode + 'A');
            return newCode;
        }
    }
}
