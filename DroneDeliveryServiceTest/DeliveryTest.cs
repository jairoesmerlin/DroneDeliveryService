using DroneDeliveryService;
using DroneDeliveryService.Classes;
namespace DroneDeliveryServiceTest;

public class DeliveryTest
{
    [Fact]
    public void Drone_ShouldDeliverToAllLocations()
    {
        Drone drone = new Drone("DroneA", 200);
        List<Location> locations = new List<Location>()
            {
                new Location("[LocationA]", 200),
                new Location("[LocationB]", 150),
                new Location("[LocationC]", 50),
                new Location("[LocationD]", 150),
                new Location("[LocationE]", 100),
                new Location("[LocationF]", 200),
                new Location("[LocationG]", 50),
                new Location("[LocationH]", 80),
                new Location("[LocationI]", 70),
                new Location("[LocationJ]", 50),
                new Location("[LocationK]", 30),
                new Location("[LocationL]", 20),
                new Location("[LocationM]", 50),
                new Location("[LocationN]", 30),
                new Location("[LocationO]", 20),
                new Location("[LocationP]", 90)
            };

        drone.Deliver(locations);
    }
}
