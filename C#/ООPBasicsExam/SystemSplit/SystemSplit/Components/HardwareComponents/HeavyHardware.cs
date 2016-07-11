namespace SystemSplit.Components.HardwareComponents
{
    public class HeavyHardware : Hardware
    {
        private const int CapacityIncreaser = 2;

        private const double MemoryDecreaser = 0.25;

        public HeavyHardware(string name, int maxCapacity, int maxMemory)
            : base(name, maxCapacity * CapacityIncreaser, maxMemory - (int)(maxMemory * MemoryDecreaser))
        {
        }
    }
}
