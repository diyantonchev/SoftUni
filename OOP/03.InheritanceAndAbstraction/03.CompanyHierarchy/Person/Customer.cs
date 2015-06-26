using System;
using Interfaces;
using System.Text;

namespace Person.Customer
{
    class Customer : Person, ICustomer
    {
        private const double MinNetPurchaseAmount = 1;

        private double netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }

            set
            {
                if (value < MinNetPurchaseAmount)
                {
                    throw new ArgumentOutOfRangeException("The net purchase amount cannot be zero or negative.");
                }
                this.netPurchaseAmount = value;
            }
        }
        public override string ToString()
        {
            var customer = new StringBuilder();

            customer.AppendLine(base.ToString());
            customer.AppendLine(string.Format("Net purchase amount: {0}", this.NetPurchaseAmount));

            return customer.ToString();
        }
    }
}
