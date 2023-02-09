namespace DroneDeliveryService.Classes
{
  public  class Drone
    {
        public string Name { get; set; }
        public int MaxWeight { get; set; }
        public List<Location> CurrentTrip { get; set; }

        public Drone(string name, int maxWeight)
        {
            Name = name;
            MaxWeight = maxWeight;
            CurrentTrip = new List<Location>();
        }

        public void Deliver(List<Location> locations)
        {
            int tripeNumber = 1;
            int remainingWeight = MaxWeight;

            for (int i = 0; i < locations.Count; i++)
            {
                if (remainingWeight >= locations[i].Weight)
                {
                    remainingWeight -= locations[i].Weight;
                    CurrentTrip.Add(locations[i]);
                    locations.RemoveAt(i);
                    i--;
                }

                if (remainingWeight == 0 || i == locations.Count - 1)
                {
                    Console.WriteLine($"Trip #{tripeNumber}");
                    Console.WriteLine(string.Join(", ", CurrentTrip));
                    Console.WriteLine();
                    tripeNumber++;
                    remainingWeight = MaxWeight;
                    CurrentTrip.Clear();
                }
            }
        }
    }

}

