namespace SystemSplit.Components.SoftwareComponents
{
    public class LightSoftware : Software
    {
        private const int CapacityConsumptionIncreaser = 2;

        private const int MemoryConsumptionDecreaser = 2;

        public LightSoftware(string name, int capacityConsumption, int memoryConsumption)
            : base(name, capacityConsumption + (capacityConsumption / CapacityConsumptionIncreaser), memoryConsumption / MemoryConsumptionDecreaser)
        {
        }
    }
}
