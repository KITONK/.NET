using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTickets
{
    public class Ticket
    {
        public DateTime DateDepature { get; set; }
        public DateTime DateArrival { get; set; }
        public string CityDepature { get; set; }
        public string CityArrival { get; set; }
        public string Seat { get; set; }

        private float _price;

        public float Price
        {
            get { return _price; }
            set 
            { 
                if (Price >= 0)
                    _price = value; 
            }
        }

        public Ticket()
        {
            DateDepature = DateTime.Now;
            DateArrival = DateTime.Now.AddHours(3);
            CityDepature = "City #1";
            CityArrival = "City #2";
            Price = 0;
            Seat = "Seat #1";

            Console.WriteLine($"{GetType().Name} default ctor called");
        }

        public Ticket(DateTime dateDepature, DateTime dateArrival, string cityDepature, string cityArrival, float price, string seat)
        {
            DateDepature = dateDepature;
            DateArrival = dateArrival;
            CityDepature = cityDepature;
            CityArrival = cityArrival;
            Price = price;
            Seat = seat;

            Console.WriteLine($"{GetType().Name} initializer ctor called");

        }

        public Ticket(Ticket tick)
        {
            DateDepature = tick.DateDepature;
            DateArrival = tick.DateArrival;
            CityDepature = tick.CityDepature;
            CityArrival = tick.CityArrival;
            Price = tick.Price;
            Seat = tick.Seat;

            Console.WriteLine($"{GetType().Name} copy ctor called");
        }
    }
}