using System;
using System.IO;
using System.Windows.Forms;

public class TestTimer
{
    static void Main()
    {
        var printOnConsole = new AsyncTimer(PrintOnConsole, 5, 900000000);
        printOnConsole.Run();

        var printOnFile = new AsyncTimer(PrintOnFile, 10, 5000);
        printOnFile.Run();

        var showMessageBox = new AsyncTimer(ShowMessageBox, 4, 100000);
        showMessageBox.Run();
    }

    static void PrintOnConsole(int number)
    {
        Console.WriteLine("{0} ", number);
        number++;
    }

    static void PrintOnFile(int number)
    {
        using (var writer = new StreamWriter("../../some.txt", true))
        {
            writer.Write("{0} ", number);
            number++;
        }
    }

   static void ShowMessageBox(int number)
    {
        MessageBox.Show(string.Format("{0}", number));
        number++;
    }
}