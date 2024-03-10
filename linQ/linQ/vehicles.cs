using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    internal class vehicles
    {
        private string name;
        private string brand;
        private int year;
        private float price;
        public vehicles() { }
        public vehicles(string name, string brand, int year, float price)
        {
            this.name = name;
            this.Brand = brand;
            this.year = year;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Year { get => year; set => year = value; }
        public float Price { get => price; set => price = value; }
    }
}
