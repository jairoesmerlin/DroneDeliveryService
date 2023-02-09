using System;
namespace DroneDeliveryService.Classes
{
  public class Location
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Location(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

