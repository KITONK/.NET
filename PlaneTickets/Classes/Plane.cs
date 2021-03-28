using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTickets
{
    public class Plane
    {
        private int _sitsNumber;

        public int SitsNumber
        {
            get { return _sitsNumber; }
            set 
            { 
                if (value > 0)
                    _sitsNumber = value; 
            }
        }

        private int _numberOfPlane;

        public int NumberOfPlane
        {
            get { return _numberOfPlane; }
            set 
            {
                if (value > 0)
                    _numberOfPlane = value; 
            }
        }

        public string TypeOfPlane { get; set; }

        public Plane()
        {
            SitsNumber = 0;
            NumberOfPlane = 0;
            TypeOfPlane = "Some type";
        }

        public Plane(int sitsNumber, int numberOfPlane, string typeOfPlane)
        {
            SitsNumber = sitsNumber;
            NumberOfPlane = numberOfPlane;
            TypeOfPlane = typeOfPlane;
        }

        public Plane(Plane pln)
        {
            SitsNumber = pln.SitsNumber;
            NumberOfPlane = pln.NumberOfPlane;
            TypeOfPlane = pln.TypeOfPlane;
        }
        
    }
}
