using System;
using System.Collections.Generic;

public class CustomerMain
{
    private static void Main()
    {
        var zaNapred = new Payment("Desyatka", 10);

        var zarko = new Customer(
            "Zarko",
            "Slunchaka",
            9502128879,
            088815500,
            "zarko@abv.bg",
            CustomerType.OneTime,
            zaNapred);

        var dancho = zarko.Clone() as Customer;
        dancho.FirstName = "Dancho";
        dancho.LastName = "Lechkov";

        Console.WriteLine(dancho);
        Console.WriteLine(zarko);

        var djordjano = new Customer(
            "Djordjano",
            "Kupona",
            85998838,
            0899339949,
            "djordjano@gmail.com",
            CustomerType.Diamond);

        var toncho = djordjano.Clone() as Customer;
        toncho.Id = 8234353535;
        toncho.LastName = "Bakarkov";

        var customers = new List<Customer> { zarko, dancho, djordjano, toncho };
        customers.Sort();

        Console.WriteLine(string.Join(", ", customers));
    }
}