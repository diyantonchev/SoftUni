using System;

public class Payment
{
    private const double MinPrice = 0;

    private double price;

    private string productName;

    public Payment(string productName, double price)
    {
        this.ProductName = productName;
        this.Price = price;
    }

    public string ProductName
    {
        get
        {
            return this.productName;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value", "Product name cannot be null, empty or white space.");
            }
            this.productName = value;
        }
    }

    public double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= MinPrice)
            {
                throw new ArgumentOutOfRangeException("value", "Price cannot be negative or zero.");
            }
            this.price = value;
        }
    }
}