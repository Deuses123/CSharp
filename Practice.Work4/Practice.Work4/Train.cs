using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{
    class Train
    {
        public int TrainNumber { get; set; }
        public string DepartureStation { get; set; }
        public string DestinationStation { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal TicketPrice { get; set; }

        public Train(int trainNumber, string departureStation, string destinationStation, DateTime departureTime, decimal ticketPrice)
        {
            TrainNumber = trainNumber;
            DepartureStation = departureStation;
            DestinationStation = destinationStation;
            DepartureTime = departureTime;
            TicketPrice = ticketPrice;
        }
    }

    class Ticket
    {
        public int TicketNumber { get; set; }
        public Train SelectedTrain { get; set; }
        public DateTime BookingTime { get; set; }
        public decimal TotalPrice { get; set; }

        public Ticket(int ticketNumber, Train selectedTrain, DateTime bookingTime, decimal totalPrice)
        {
            TicketNumber = ticketNumber;
            SelectedTrain = selectedTrain;
            BookingTime = bookingTime;
            TotalPrice = totalPrice;
        }
    }

    class Passenger
    {
        public string Name { get; set; }

        public Passenger(string name)
        {
            Name = name;
        }

        public Ticket MakeReservation(BookingSystem bookingSystem, string departureStation, string destinationStation, DateTime departureTime)
        {
            Train availableTrain = bookingSystem.FindAvailableTrain(departureStation, destinationStation, departureTime);
            if (availableTrain != null)
            {
                decimal totalPrice = availableTrain.TicketPrice;
                Ticket ticket = new Ticket(GenerateTicketNumber(), availableTrain, DateTime.Now, totalPrice);
                return ticket;
            }
            else
            {
                Console.WriteLine("No available trains found for the requested route and time.");
                return null;
            }
        }

        private int GenerateTicketNumber()
        {
            // Генерация уникального номера билета (простой пример)
            Random random = new Random();
            return random.Next(1000, 10000);
        }
    }

    class BookingSystem
    {
        private List<Train> trains;

        public BookingSystem()
        {
            trains = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            trains.Add(train);
        }

        public Train FindAvailableTrain(string departureStation, string destinationStation, DateTime departureTime)
        {
            foreach (Train train in trains)
            {
                if (train.DepartureStation.Equals(departureStation, StringComparison.OrdinalIgnoreCase)
                    && train.DestinationStation.Equals(destinationStation, StringComparison.OrdinalIgnoreCase)
                    && train.DepartureTime == departureTime)
                {
                    return train;
                }
            }
            return null;
        }
    }

    class Cashier
    {
        public void GenerateInvoice(Ticket ticket)
        {
            Console.WriteLine($"Invoice for Ticket #{ticket.TicketNumber}:");
            Console.WriteLine($"Train: {ticket.SelectedTrain.TrainNumber}");
            Console.WriteLine($"Departure: {ticket.SelectedTrain.DepartureStation}");
            Console.WriteLine($"Destination: {ticket.SelectedTrain.DestinationStation}");
            Console.WriteLine($"Departure Time: {ticket.SelectedTrain.DepartureTime}");
            Console.WriteLine($"Total Price: {ticket.TotalPrice:C}");
        }
    }
}
