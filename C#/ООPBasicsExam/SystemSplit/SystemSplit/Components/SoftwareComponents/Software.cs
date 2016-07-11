namespace SystemSplit.Components.SoftwareComponents
{
    using System;

    public abstract class Software : SystemComponent
    {
        private int capacityConsumption;

        private int memoryConsumption;

        protected Software(string name, int capacityConsumption, int memoryConsumption)
            : base(name)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public int CapacityConsumption
        {
            get
            {
                return this.capacityConsumption;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Software component's capacity consumption cannot be negative number.");
                }

                this.capacityConsumption = value;
            }
        }

        public int MemoryConsumption
        {
            get
            {
                return this.memoryConsumption;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Software component's memory consumption cannot be negative number.");
                }

                this.memoryConsumption = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
