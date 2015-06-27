using System;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, double price) : base(title, author, price) 
    {
        this.Price = price;
    }

    public override double Price
    {
        get
        {
            return (base.Price * (30/100) + base.Price);
        }
        protected set
        {
            base.Price = value;
        }
    }
}
