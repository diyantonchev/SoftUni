using System;
using System.Text;

class Component
    {
        private string name;
        private double price;
        private string details;

        public Component(string name, double price)
        {
            this.Price = price;
            this.Name = name;
        }

        public Component(string name, double price, string details): this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get { return this.Name = name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                    throw new ArgumentException("Incorrect name");
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The price can not be negative");
                this.price = value;
            }
        }

        public string Details
        { 
            get {return this.details ;}
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid details");
                this.details = value;
            }
        }
        public override string ToString()
        {
            var components = new StringBuilder();

            components.Append(string.Format("{0}, ", this.name));

            if (this.details != null)
            {
                components.Append(string.Format("{0}, ", this.details));
            }

            components.AppendLine(string.Format("price {0:C}", this.price));

            return components.ToString();
        }
    }

