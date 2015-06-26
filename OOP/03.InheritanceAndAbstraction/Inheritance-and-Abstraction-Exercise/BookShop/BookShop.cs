using System;

class BookShop
{
    static void Main()
    {
        var podIgoto = new Book("Pod Igoto", "Ivan Vazov", 15.90);

        var tutun = new GoldenEditionBook("Tutun", "Dimitar Dimov", 29.77);

        Console.WriteLine("{0}\n\n{1}", podIgoto, tutun);
    }
}
