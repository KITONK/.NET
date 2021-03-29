using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTickets
{
    public class Flight
    {
        private Plane _plane;
        public DateTime DateDepature { get; set; }
        public DateTime DateArrival { get; set; }
        public string CityDepature { get; set; }
        public string CityArrival { get; set; }

        public Flight()
        {
            DateDepature = DateTime.Now;
            DateArrival = DateTime.Now.AddHours(3);
            CityDepature = "City #1";
            CityArrival = "City #2";

            Console.WriteLine($"{GetType().Name} default ctor called");
        }

        public Flight(DateTime dateDepature, DateTime dateArrival, string cityDepature, string cityArrival)
        {
            DateDepature = dateDepature;
            DateArrival = dateArrival;
            CityDepature = cityDepature;
            CityArrival = cityArrival;

            Console.WriteLine($"{GetType().Name} default ctor called");
        }

        public Flight(Flight flt)
        {
            DateDepature = flt.DateDepature;
            DateArrival = flt.DateArrival;
            CityDepature = flt.CityDepature;
            CityArrival = flt.CityArrival;

            Console.WriteLine($"{GetType().Name} default ctor called");
        }
    }
}



