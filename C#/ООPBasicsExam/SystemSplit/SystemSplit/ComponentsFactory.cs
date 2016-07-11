namespace SystemSplit
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Components.HardwareComponents;
    using Components.SoftwareComponents;

    public static class ComponentsFactory
    {
        public static void RegisterComponent(Match info)
        {
            var command = info.Groups[1].Value;
            switch (command)
            {
                case "RegisterPowerHardware":
                    RegisterPowerHardware(info.Groups[2].Value);
                    break;
                case "RegisterHeavyHardware":
                    RegisterHeavyHardware(info.Groups[2].Value);
                    break;
                case "RegisterExpressSoftware":
                    RegisterExpressSoftware(info.Groups[2].Value);
                    break;
                case "RegisterLightSoftware":
                    RegisterLigthSoftware(info.Groups[2].Value);
                    break;
                //default:
                //    throw new ArgumentException("No such component type in The System.");
            }
        }

        private static void RegisterPowerHardware(string info)
        {
            string[] componentInfo = info.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string name = componentInfo[0];
            int capacity = int.Parse(componentInfo[1]);
            int memory = int.Parse(componentInfo[2]);

            var powerHardware = new PowerHardware(name, capacity, memory);
            TheSystem.Components.Add(powerHardware);
        }

        private static void RegisterHeavyHardware(string info)
        {
            string[] componentInfo = info.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string name = componentInfo[0];
            int capacity = int.Parse(componentInfo[1]);
            int memory = int.Parse(componentInfo[2]);

            var heavyHardware = new HeavyHardware(name, capacity, memory);
            TheSystem.Components.Add(heavyHardware);
        }

        private static void RegisterExpressSoftware(string info)
        {
            string[] componentInfo = info.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string hardwareComponentName = componentInfo[0];

            bool isHardwareExists = TheSystem.Components.Exists(c => c.Name == hardwareComponentName);
            if (isHardwareExists)
            {
                var hardwareComponent = TheSystem.Components.First(c => c.Name == hardwareComponentName);

                string name = componentInfo[1];
                int capacityConsumption = int.Parse(componentInfo[2]);
                int memoryConsumption = int.Parse(componentInfo[3]);

                var expressSoftware = new ExpressSoftware(name, capacityConsumption, memoryConsumption);

                bool hasEnoughCapacity = hardwareComponent.AvailableCapacity >= expressSoftware.CapacityConsumption;
                bool hasEnoughMemory = hardwareComponent.AvailableMemory >= expressSoftware.MemoryConsumption;
                if (hasEnoughCapacity && hasEnoughMemory)
                {
                    hardwareComponent.AvailableCapacity -= expressSoftware.CapacityConsumption;
                    hardwareComponent.AvailableMemory -= expressSoftware.MemoryConsumption;
                    hardwareComponent.SoftwareComponents.Add(expressSoftware);
                }
            }
        }

        private static void RegisterLigthSoftware(string info)
        {
            string[] componentInfo = info.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string hardwareComponentName = componentInfo[0];

            bool isHardwareExists = TheSystem.Components.Exists(c => c.Name == hardwareComponentName);
            if (isHardwareExists)
            {
                var hardwareComponent = TheSystem.Components.First(c => c.Name == hardwareComponentName);

                string name = componentInfo[1];
                int capacityConsumption = int.Parse(componentInfo[2]);
                int memoryConsumption = int.Parse(componentInfo[3]);

                var lightSoftware = new LightSoftware(name, capacityConsumption, memoryConsumption);

                bool hasEnoughCapacity = hardwareComponent.AvailableCapacity >= lightSoftware.CapacityConsumption;
                bool hasEnoughMemory = hardwareComponent.AvailableMemory >= lightSoftware.MemoryConsumption;
                if (hasEnoughCapacity && hasEnoughMemory)
                {
                    hardwareComponent.AvailableCapacity -= lightSoftware.CapacityConsumption;
                    hardwareComponent.AvailableMemory -= lightSoftware.MemoryConsumption;
                    hardwareComponent.SoftwareComponents.Add(lightSoftware);
                }
            }
        }
    }
}
