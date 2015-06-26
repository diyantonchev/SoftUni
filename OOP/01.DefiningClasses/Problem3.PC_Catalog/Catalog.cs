using System;
using System.Collections.Generic;
using System.Linq;

class Catalog
{
    static void Main()
    {
        var HDD = new Component("SSD Intel 530 Ser.", 149.04, "120GB SATA");
        var graphicsCard = new Component("Palit GTX750Ti KalmX", 321.00, "2GB");
        var motherboard = new Component("ASROCK 970 PERFORMANCE", 201.59);
        var processor = new Component("Intel i5-4460", 386.21, "3.2GHz 6MBs.1150");

        var myComponents = new List<Component>();
        myComponents.Add(processor);
        myComponents.Add(HDD);
        myComponents.Add(motherboard);
        myComponents.Add(graphicsCard);

        var hardDiscDrive = new Component("SSD KINGSTON", 190.51, "240GB V300 SATA3");
        var videoCard = new Component("Palit Nvidia", 197.10, " GT740 2GB DDR5");
        var CPU = new Component("AMD A8", 205.44, "X4 7650K BOX s.FM2+");
        var monitor = new Component("23\'\' Samsung", 321.00, " C23A750X Wireles");

        var yourComponents = new List<Component>() { hardDiscDrive, videoCard, CPU, monitor};

        var computer = new Computer("MyComputer", myComponents);
        var secondComputer = new Computer("YourComputer",yourComponents);

        var computers = new List<Computer>() { computer, secondComputer };

        computers.OrderBy(c => c.Price).ToList().ForEach(c => Console.WriteLine(c.ToString()));
    }
}
