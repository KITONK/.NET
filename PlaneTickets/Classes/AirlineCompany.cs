using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTickets
{
    public class AirlineCompany
    {
        private List<Flight> availableFlights = new List<Flight>();
        private List<Ticket> bookedTickets = new List<Ticket>();

        public List<Flight> GetFlights()
        {
            return availableFlights;
        }

        public List<Ticket> GetBookedTickets() 
        {
            return bookedTickets;
        }

        public void BuyTicket(Ticket ticket)
        {
            bookedTickets.Add(ticket);
        }

    }
}
