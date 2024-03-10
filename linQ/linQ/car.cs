using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    internal class car:vehicles
    {
        private int numberOfSeats;
        public car() { }
        public car(string name, string brand, int year, float price, int numberOfSeats) : base(name, brand, year, price)
        {
            this.numberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}
