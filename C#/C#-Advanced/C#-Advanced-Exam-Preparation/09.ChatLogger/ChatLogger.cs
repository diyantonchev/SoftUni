using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class ChatLogger
{
    static void Main()
    {
        var messages = new Dictionary<string, DateTime>();

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        DateTime currentDateTime = DateTime.Parse(Console.ReadLine());

        var input = Console.ReadLine();

        while (input != "END")
        {
            var messageAndDateTime = Regex.Split(input,@" / ");
             
            string message = messageAndDateTime[0].Trim();
            DateTime date = DateTime.Parse(messageAndDateTime[1].Trim());

            messages[message] = date;

            input = Console.ReadLine();
        }

        var sortedMessages = messages.OrderBy(msg => msg.Value);

        DateTime lastMsgTime = sortedMessages.Select(m => m.Value).Last();

        var timeDifference = currentDateTime - lastMsgTime;

        var dayDifferece = currentDateTime.Day - lastMsgTime.Day;

        var lastActive = new StringBuilder();

        if (dayDifferece > 0)
        {
            if (dayDifferece == 1)
            {
                lastActive.AppendFormat(
                "Last active: {0}yesterday{1}"
                , "<time>"
                , "</time>"
                );
            }
            else
            {
                var sb = new StringBuilder();
                if (lastMsgTime.Day < 10)
                {
                    sb.AppendFormat(
                    lastMsgTime.Month > 9 ? "0{0}-{1}-{2}" : "0{0}-0{1}-{2}",
                    lastMsgTime.Day,
                    lastMsgTime.Month,
                    lastMsgTime.Year);
                }
                else
                {
                    sb.AppendFormat(
                   lastMsgTime.Month > 9 ? "{0}-{1}-{2}" : "{0}-0{1}-{2}",
                   lastMsgTime.Day,
                   lastMsgTime.Month,
                   lastMsgTime.Year);
                }
               
                lastActive.AppendFormat(
                "Last active: {0}{1}{2}"
                , "<time>"
                , sb
                , "</time>"
                );
            }

        }
        else if (timeDifference.Hours >= 1)
        {
            lastActive.AppendFormat(
                "Last active: {0}{1} hour(s) ago{2}",
                ("<time>"),
                timeDifference.Hours,
                ("</time>"));
        }
        else if (timeDifference.Hours < 1 && timeDifference.Minutes > 0)
        {
            lastActive.AppendFormat(
                 "Last active: {0}{1} minute(s) ago{2}",
                "<time>",
                timeDifference.Minutes,
               "</time>");
        }
        else if (timeDifference.Minutes < 1)
        {
            lastActive.AppendFormat("Last active: {0}a few moments ago{1}"
                , "<time>"
                , "</time>");
        }

        foreach (var couple in sortedMessages)
        {
            Console.Write("<div>");
            Console.Write("{0}", SecurityElement.Escape(couple.Key));
            Console.WriteLine("</div>");
        }
        Console.WriteLine("{0}{1}{2}"
               , "<p>",
              lastActive,
              "</p>"
               );
    }
}