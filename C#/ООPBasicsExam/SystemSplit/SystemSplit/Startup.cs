namespace SystemSplit
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Components.HardwareComponents;
    using Components.SoftwareComponents;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "System Split")
            {
                const string Pattern = "(\\w+)\\(([\\w,\\d\\s]*)\\)";
                var regex = new Regex(Pattern);
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var command = match.Groups[1].Value;

                    if (command == "Analyze")
                    {
                        int hardwareComponentsCount = TheSystem.Components.Count;
                        int softwareComponentsCount = TheSystem.Components.Sum(c => c.SoftwareComponents.Count);
                        int totalMemoryTaken = TheSystem.Components.Sum(c => c.SoftwareComponents.Sum(s => s.MemoryConsumption));
                        int maxMemory = TheSystem.Components.Sum(c => c.MaxMemory);
                        int totalCapacityTaken = TheSystem.Components.Sum(c => c.SoftwareComponents.Sum(s => s.CapacityConsumption));
                        int maxCapacity = TheSystem.Components.Sum(c => c.MaxCapacity);

                        Console.WriteLine("System Analysis");
                        Console.WriteLine($"Hardware Components: {hardwareComponentsCount}");
                        Console.WriteLine($"Software Components: {softwareComponentsCount}");
                        Console.WriteLine($"Total Operational Memory: {totalMemoryTaken} / {maxMemory}");
                        Console.WriteLine($"Total Capacity Taken: {totalCapacityTaken} / {maxCapacity}");
                    }
                    else if (command == "ReleaseSoftwareComponent")
                    {
                        string[] components = match.Groups[2].Value.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        var hardwareComponent = TheSystem.Components.First(c => c.Name == components[0]);
                        hardwareComponent.SoftwareComponents.RemoveAll(s => s.Name == components[1]);
                    }
                    else if (command == "Dump")
                    {
                        string componentName = match.Groups[2].Value;
                        TheSystem.Dump.Add(TheSystem.Components.First(c => c.Name == componentName));
                        TheSystem.Components.RemoveAll(c => c.Name == componentName);
                    }
                    else if (command == "Restore")
                    {
                        string componentName = match.Groups[2].Value;
                        TheSystem.Components.Add(TheSystem.Dump.First(c => c.Name == componentName));
                        TheSystem.Dump.RemoveAll(c => c.Name == componentName);
                    }
                    else if (command == "Destroy")
                    {
                        string componentName = match.Groups[2].Value;
                        TheSystem.Dump.RemoveAll(c => c.Name == componentName);
                    }
                    else if (command == "DumpAnalyze")
                    {
                        Console.WriteLine("Dump Analysis");
                        int powerHardwareCount = TheSystem.Dump.Count(c => c is PowerHardware);
                        int heavyHardwareCount = TheSystem.Dump.Count(c => c is HeavyHardware);
                        int expressSoftwareCount = TheSystem.Dump.Sum(c => c.SoftwareComponents.Count(s => s is ExpressSoftware));
                        int lightSoftwareCount = TheSystem.Dump.Sum(c => c.SoftwareComponents.Count(s => s is LightSoftware));
                        int totalDumpedMemory = TheSystem.Dump.Sum(c => c.SoftwareComponents.Sum(s => s.MemoryConsumption));
                        int totalDumpedCapacity = TheSystem.Dump.Sum(c => c.SoftwareComponents.Sum(s => s.CapacityConsumption));
                        Console.WriteLine($"Power Hardware Components: {powerHardwareCount}");
                        Console.WriteLine($"Heavy Hardware Components: {heavyHardwareCount}");
                        Console.WriteLine($"Express Software Components: {expressSoftwareCount}");
                        Console.WriteLine($"Light Software Components: { lightSoftwareCount}");
                        Console.WriteLine($"Total Dumped Memory: { totalDumpedMemory}");
                        Console.WriteLine($"Total Dumped Capacity: {totalDumpedCapacity}");
                    }
                    else
                    {
                        ComponentsFactory.RegisterComponent(match);
                    }

                }
                else
                {
                    throw new ArgumentException("No such command.");
                }

                input = Console.ReadLine();
            }

            var powerHardwares = TheSystem.Components.Where(c => c is PowerHardware).ToList();
            var heavyHardwares = TheSystem.Components.Where(c => c is HeavyHardware).ToList();

            powerHardwares.ForEach(c =>
            {
                var memoryUsage = c.SoftwareComponents.Sum(s => s.MemoryConsumption);
                var capacityUsage = c.SoftwareComponents.Sum(s => s.CapacityConsumption);
                Console.WriteLine($"Hardware Component - {c.Name}");
                Console.WriteLine($"Express Software Components - {c.SoftwareComponents.Count(s => s is ExpressSoftware)}");
                Console.WriteLine($"Light Software Components - {c.SoftwareComponents.Count(s => s is LightSoftware)}");
                Console.WriteLine($"Memory Usage: {memoryUsage} / {c.MaxMemory}");
                Console.WriteLine($"Capacity Usage: {capacityUsage} / {c.MaxCapacity}");
                Console.WriteLine($"Type: Power");
                Console.WriteLine(c.SoftwareComponents.Any() ?
                    $"Software Components: {string.Join(", ", c.SoftwareComponents)}" : "Software Components: None");
            });

            heavyHardwares.ForEach(c =>
            {
                var memoryUsage = c.SoftwareComponents.Sum(s => s.MemoryConsumption);
                var capacityUsage = c.SoftwareComponents.Sum(s => s.CapacityConsumption);
                Console.WriteLine($"Hardware Component - {c.Name}");
                Console.WriteLine($"Express Software Components - {c.SoftwareComponents.Count(s => s is ExpressSoftware)}");
                Console.WriteLine($"Light Software Components - {c.SoftwareComponents.Count(s => s is LightSoftware)}");
                Console.WriteLine($"Memory Usage: {memoryUsage} / {c.MaxMemory}");
                Console.WriteLine($"Capacity Usage: {capacityUsage} / {c.MaxCapacity}");
                Console.WriteLine($"Type: Heavy");
                Console.WriteLine(c.SoftwareComponents.Any() ?
                    $"Software Components: {string.Join(", ", c.SoftwareComponents)}" : "Software Components: None");
            });
        }
    }
}
