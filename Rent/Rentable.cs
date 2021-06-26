using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    class Rentable
    {
        public bool Availabe { get; set; }
        public int Beds { get; set; }
        public bool Kitchen { get; set; }
        public bool Shower { get; set; }
        public int Floor { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }

        public Rentable(int beds, bool kitchen, bool shower, int floor, string name, double price)
        {
            Availabe = true;
            Beds = beds;
            Kitchen = kitchen;
            Shower = shower;
            Floor = floor;
            Name = name;
            Price = price;
        }

        public Rentable()
        {
            Availabe = true ;
        }

        public override bool Equals(object obj)
        {
            Rentable o = (Rentable)obj;
            return this.Name.Equals(o.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Laisvas: " + Availabe + " lovos: " + Beds + " virtuvė: " + Kitchen + " dušas: " + Shower + " Aukštas: " + Floor + " pavadinimas/numeris: " + Name
                 + " Kaina: " + Price;
        }
    }
 
}
