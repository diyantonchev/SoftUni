namespace SystemSplit.Components.HardwareComponents
{
    using System;
    using System.Collections.Generic;

    using SoftwareComponents;

    public abstract class Hardware : SystemComponent
    {
        private int maxCapacity;

        private int availableCapacity;

        private int maxMemory;

        private int availableMemory;

        protected Hardware(string name, int maxCapacity, int maxMemory)
            : base(name)
        {
            this.AvailableCapacity = maxCapacity;
            this.AvailableMemory = maxMemory;
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
            this.SoftwareComponents = new List<Software>();
        }

        public int AvailableCapacity
        {
            get
            {
                return this.availableCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hardware's capacity cannot be negative number.");
                }

                this.availableCapacity = value;
            }
        }

        public int AvailableMemory
        {
            get
            {
                return this.availableMemory;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hardware's memory cannot be negative number.");
                }

                this.availableMemory = value;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return this.maxCapacity;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hardware's capacity cannot be negative number.");
                }

                this.maxCapacity = value;
            }
        }

        public int MaxMemory
        {
            get
            {
                return this.maxMemory;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hardware's memory cannot be negative number.");
                }

                this.maxMemory = value;
            }
        }

        public List<Software> SoftwareComponents { get; set; }
    }
}
