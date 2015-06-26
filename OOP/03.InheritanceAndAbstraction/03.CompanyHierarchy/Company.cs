using System;
using System.Collections.Generic;
using System.Linq;
using Person;
using Person.Employee;
using Person.Customer;

class Company
{
    static void Main()
    {
        var jaime = new Developer("PRGH45M", "Jaime", "Lannister", 3500, Department.Marketing);

        //var handStartDate = new DateTime(12,03,15);
        //var createHand = new Project("hand", handStartDate, "Some Details", "open");
        //Project.CloseProject(createHand);
        //Console.WriteLine(createHand.State);

        var tyrion = new SalesEmployee("100D445HG", "Tyrion", "Lannister", 3000, Department.Sales);

        var cersei = new Manager("900HGAD34", "Cersei", "Lannister", 5000, Department.Production);

        var lannisters = new List<Employee>()
        {
            jaime,
            tyrion,
            cersei
        };

        foreach (var lannisterEmployee in lannisters)
        {
            Console.WriteLine(lannisterEmployee);
        }
    }
}

