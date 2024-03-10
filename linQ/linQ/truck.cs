using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    internal class truck:vehicles
    {
        private string ownerCompany;
        public truck() { }
        public truck(string name, string brand, int year, float price, string ownerCompany) : base(name, brand, year, price)
        {
            this.ownerCompany = ownerCompany;
        }

        public string OwnerCompany { get => ownerCompany; set => ownerCompany = value; }
    }
}
