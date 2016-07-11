namespace SystemSplit
{
    using System.Collections.Generic;

    using Components.HardwareComponents;

    public static class TheSystem
    {
        static TheSystem()
        {
            Components = new List<Hardware>();
            Dump = new List<Hardware>();
        }

        public static List<Hardware> Components { get; set; }

        public static List<Hardware> Dump { get; set; }
    }
}
