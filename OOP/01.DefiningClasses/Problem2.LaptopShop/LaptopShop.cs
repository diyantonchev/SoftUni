using System;

class LaptopShop
{
    static void Main()
    {
        var mandatoryLaptop = new Laptop("HP 250 G2", (decimal)699.00);
       
        var fullLaptop = new Laptop("Lenovo Yoga 2 Pro", (decimal)2259.00)
        {
            Manufacturer = "Lenovo",
            Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
            RAM  = 8,
            GraphicsCard = "Intel HD Graphics 4400",
            HDD = "128GB SSD",
            Screen = "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
            Battery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5)
        };

        Console.WriteLine(mandatoryLaptop);
        Console.WriteLine();
        Console.WriteLine(fullLaptop);
    }
}

