namespace SystemSplit.Components
{
    using System;

    public abstract class SystemComponent
    {
        private string name;

        protected SystemComponent(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("System component's name cannot be null or empty.");
                }

                this.name = value;
            }
        }
    }
}
