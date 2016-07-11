namespace SystemSplit.Components.SoftwareComponents
{
    public class ExpressSoftware : Software
    {
        private const int MemoryConsumptionIncreaser = 2;

        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption)
            : base(name, capacityConsumption, memoryConsumption * MemoryConsumptionIncreaser)
        {
        }
    }
}
