using System;
using System.Collections.Generic;

namespace DroneDeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drones = new Dictionary<string, int>()
            {
                { "DroneA", 200 },
                { "DroneB", 250 },
                { "DroneC", 100 }
            };

            List<Tuple<string, int>> locations = new List<Tuple<string, int>>
            {
                new Tuple<string, int>("LocationA", 200),
                new Tuple<string, int>("LocationB", 150),
                new Tuple<string, int>("LocationC", 50),
                new Tuple<string, int>("LocationD", 150 ),
                new Tuple<string, int>("LocationE", 100 ),
                new Tuple<string, int>("LocationF", 200),
                new Tuple<string, int>("LocationG", 50),
                new Tuple<string, int>("LocationH", 80),
                new Tuple<string, int>("LocationI", 70),
                new Tuple<string, int>("LocationJ", 50),
                new Tuple<string, int>("LocationK", 30),
                new Tuple<string, int>("LocationL", 20),
                new Tuple<string, int>("LocationM", 50),
                new Tuple<string, int>("LocationN", 30 ),
                new Tuple<string, int>("LocationO", 20),
                new Tuple<string, int>("LocationP", 90)
            };
            foreach (var drone in drones)
            {
                Console.WriteLine($"Drone: {drone.Key}");
                int tripeNumber = 1;
                int remainingWeight = drone.Value;
                List<string> currentTrip = new List<string>();

                for (int i = 0; i < locations.Count; i++)
                {
                    if (remainingWeight >= locations[i].Item2)
                    {
                        remainingWeight -= locations[i].Item2;
                        currentTrip.Add(locations[i].Item1);
                        locations.RemoveAt(i);
                        i--;
                    }

                    if (remainingWeight == 0 || i == locations.Count - 1)
                    {
                        Console.WriteLine($"Trip #{tripeNumber}");
                        Console.WriteLine("Deliveries: " + string.Join(", ", currentTrip));
                        Console.WriteLine();
                        tripeNumber++;
                        remainingWeight = drone.Value;
                        currentTrip.Clear();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
