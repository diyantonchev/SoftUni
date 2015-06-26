using System;
using Interfaces;
using System.Text;

public class Sale : ISale
{
    private const double MinPrice = 1;

    private string productName;
    private DateTime date;
    double price;

    public Sale(string productName, DateTime date, double price)
    {
        this.ProductName = productName;
        this.Date = date;
        this.Price = price;
    }

    public string ProductName 
    {
        get {return this.productName ;}
       
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value","The product name cannot be null, empty or whitespace.");
            }
            this.productName = value;
        }
    }

    public DateTime Date 
    {
        get { return this.date;}

        set { this.date = value; }
    }

    public double Price 
    {
        get { return this.price; }

        set
        {
            if (value < MinPrice)
                throw new ArgumentOutOfRangeException("The price cannot be negative or zero.");
            this.price = value;
        }
    }

    public override string ToString()
    {
        var sale = new StringBuilder();

        sale.AppendLine(string.Format("Product name:{0} Date:{1} Price:{2}", this.productName, this.Date, this.Price));

        return sale.ToString();
    }
}
