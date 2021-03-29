using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTickets.Classes
{
    public static class CtorsTest
    {
        public static void Test()
        {
            Ticket ticket1 = new Ticket();
            Ticket ticket2 = new Ticket(new DateTime(2021, 7, 20, 18, 30, 00), new DateTime(2021, 7, 20, 18, 30, 00), "London", "New-York", 1000, "0A");
            Ticket ticket3 = new Ticket(ticket2);

            Flight flight1 = new Flight();
            Flight flight2 = new Flight(new DateTime(2021, 7, 20, 18, 30, 00), new DateTime(2021, 7, 20, 18, 30, 00), "London", "New-York");
            Flight flight3 = new Flight(flight2);

            Plane plane1 = new Plane();
            Plane plane2 = new Plane(100, 111, "Passenger");
            Plane plane3 = new Plane(plane2);
        }
        
    }
}
