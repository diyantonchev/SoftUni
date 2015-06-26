using System;
using System.Text;

    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string batteryType ,double batteryLife): this(batteryType)
        {
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                    throw new ArgumentException("Incorrect battery type!");
                this.batteryType = value;
            }
        }

        public double BatteryLife 
        {
            get {return this.batteryLife ;} 
            set
            {
                if (value < 0 && value > 5.5)
                    throw new ArgumentException("Invalid battery life!");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            var batteryInformation = new StringBuilder();

            if (this.batteryType != null)
            {
                batteryInformation.AppendLine(String.Format("battery: {0}", this.batteryType));
            }
            if (this.batteryLife > 0)
            {
                batteryInformation.Append(String.Format("battery life: {0} hours", this.batteryLife));
            }
            return batteryInformation.ToString();
        }

    }
