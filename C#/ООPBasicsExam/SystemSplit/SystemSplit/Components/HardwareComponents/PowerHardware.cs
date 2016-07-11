namespace SystemSplit.Components.HardwareComponents
{
    public class PowerHardware : Hardware
    {
        private const double CapacityDecraser = 0.75;

        private const double MemoryIncreaser = 0.75;

        public PowerHardware(string name, int maxCapacity, int maxMemory)
            : base(name, maxCapacity - (int)(maxCapacity * CapacityDecraser), maxMemory + (int)(maxMemory * MemoryIncreaser))
        {
        }
    }
}
