using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get { return this.title;} 
        
       protected set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("The title cannot be null or empty");
            this.title = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        
     protected set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("The author cannot be null or empty.");
            this.author = value;
        }
    }
    public virtual double Price 
    {
      get { return this.price;}

      protected set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The price cannot be negative.");
            this.price = value;
        } 
    }

    public override string ToString()
    {
        var bookInformation = new StringBuilder();

        bookInformation.AppendLine(string.Format("-Type: {0}", this.GetType()));
        bookInformation.AppendLine(string.Format("-Title: {0}", this.title));
        bookInformation.AppendLine(string.Format("-Author: {0}", this.author));
        bookInformation.Append(string.Format("-Price: {0:F2}", this.price));

        return bookInformation.ToString();
    }
}
