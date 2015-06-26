using System;

class Persons
{
    static void Main()
    {
        var Zapryan = new Person("Zapryan", 30); 
        var Tsonko = new Person("Tsonko", 55, "kmetalista@kavarna.bg");
        var noOne = new Person("Valar Morghulis", 99, "ThereIsOnlyOneGod@AndTheGirlKnowsHisName"); 
        //var Gamena = new Person("Gamena", 29, "IbasiGolemiteRykiChvqk");  // Invalid Name, Invalid e-mail
        //var Nakov = new Person("Nakov", 110, "nakov@softuni.bg"); // Invalid Age     

        Console.WriteLine(Zapryan);
        Console.WriteLine(Tsonko);
        Console.WriteLine(noOne);
        //Console.WriteLine(Gamena);       
    }
}
