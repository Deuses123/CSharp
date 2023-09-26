using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{
    class Car
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public bool IsAvailable { get; set; }

        public Car(string model, string licensePlate)
        {
            Model = model;
            LicensePlate = licensePlate;
            IsAvailable = true;
        }
    }

    class Trip
    {
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public bool IsCompleted { get; set; }

        public Trip(string destination, DateTime departureTime)
        {
            Destination = destination;
            DepartureTime = departureTime;
            IsCompleted = false;
        }
    }

    class Driver
    {
        public string Name { get; set; }
        public Car AssignedCar { get; set; }
        public List<Trip> Trips { get; set; }

        public Driver(string name)
        {
            Name = name;
            Trips = new List<Trip>();
        }

        public void MakeTripRequest(Trip trip)
        {
            if (AssignedCar != null && AssignedCar.IsAvailable)
            {
                Trips.Add(trip);
                Console.WriteLine($"{Name} has requested a trip to {trip.Destination}.");
            }
            else
            {
                Console.WriteLine($"{Name} cannot make a trip request because the assigned car is not available.");
            }
        }

        public void MarkTripAsCompleted(Trip trip)
        {
            if (Trips.Contains(trip))
            {
                Trips.Remove(trip);
                trip.IsCompleted = true;
                Console.WriteLine($"{Name} has marked the trip to {trip.Destination} as completed.");
            }
        }

        public void ReportCarMaintenanceIssue()
        {
            if (AssignedCar != null)
            {
                AssignedCar.IsAvailable = false;
                Console.WriteLine($"{Name} has reported a maintenance issue for the assigned car ({AssignedCar.Model}).");
            }
        }
    }

    class Dispatcher
    {
        public void AssignCarToDriver(Driver driver, Car car)
        {
            driver.AssignedCar = car;
            car.IsAvailable = true;
            Console.WriteLine($"Assigned car ({car.Model}, License Plate: {car.LicensePlate}) to {driver.Name}.");
        }

        public void SuspendDriver(Driver driver)
        {
            driver.AssignedCar = null;
            Console.WriteLine($"Suspended {driver.Name} from work.");
        }
    }
}
