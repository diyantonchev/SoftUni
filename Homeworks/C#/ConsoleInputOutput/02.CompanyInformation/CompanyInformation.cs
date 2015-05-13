using System;

    class CompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter information about your company!");
            
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company adress: ");
            string adress = Console.ReadLine();

            Console.Write("Fax number: ");
            string fax = Console.ReadLine();

            Console.Write("Web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string lastName =  Console.ReadLine();

            Console.Write("Manager age: ");
            string mAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            string mPhone = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Company name: " + companyName);
            Console.WriteLine("Company adress: " + adress);
            Console.WriteLine("Fax number: " + fax);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, mAge, mPhone );           
	    }
            

    }
    

