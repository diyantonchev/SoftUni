using System;
using System.Text;

class Laptop
{
    private string model;
    private decimal price;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hardDiscDrive;
    private string screen;

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(
        string model, decimal price,
        string manufacturer, string processor,
        int ram, string graphicsCard,
        string hardDiskDrive, string Screen, Battery battery) : this (model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.Screen = screen;
        this.GraphicsCard = graphicsCard;
        this.Battery = battery;
        this.HDD = hardDiscDrive;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid name!");
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set 
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
                throw new ArgumentException("Inncorect name!");
            this.manufacturer = value;
        }
    }

    public string Processor 
    {
        get { return this.processor; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Inncorect name!");
            this.processor = value;
        }
    }

    public int RAM
    {
        get { return this.ram; }
        set
        {
            if (value < 1 && value > 16)
                throw new ArgumentException("Inncorect RAM input!");
            this.ram = value;
        }
    }

    public string GraphicsCard 
    {
        get { return this.graphicsCard; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid parameters!");
            this.graphicsCard = value;
        }
    }

    public string HDD 
    {
        get { return this.hardDiscDrive; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid parameters!");
            this.hardDiscDrive = value;
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid parameters!");
            this.screen = value;
        }
    }

    public decimal Price
    {
        get { return  price; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Price can not be negative!");
            this.price = value;
        }
    }

    public Battery Battery { get; set; }

    public override string ToString()
    {
        var laptopParameters = new StringBuilder();

        laptopParameters.AppendLine(string.Format("model: {0}", this.model));
        if (this.manufacturer != null)
        {
            laptopParameters.AppendLine(string.Format("manufacturer: {0}", this.manufacturer));
        }
        if (this.processor != null)
        {
            laptopParameters.AppendLine(string.Format("processor: {0}", this.processor));
        }
        if (ram > 0 && ram < 32)
        {
            laptopParameters.AppendLine(string.Format("RAM: {0} GB", this.ram.ToString()));
        }
        if (this.graphicsCard != null)
        {
            laptopParameters.AppendLine(string.Format("graphicsCard: {0}", this.graphicsCard));
        }
        if (this.hardDiscDrive != null)
        {
            laptopParameters.AppendLine(string.Format("HDD: {0}", this.hardDiscDrive));
        }
        if (this.screen != null)
        {
            laptopParameters.AppendLine(string.Format("screen: {0}", this.screen));
        }
        if (this.Battery != null)
        {
            laptopParameters.AppendLine(Battery.ToString());
        }
        laptopParameters.Append(string.Format("price: {0} lv.", this.price.ToString()));

        return laptopParameters.ToString();
    } 
}