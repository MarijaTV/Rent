using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    class Rentable
    {
        public bool Available { get; set; }
        public int Beds { get; set; }
        public bool Kitchen { get; set; }
        public bool Shower { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }

        public Rentable(int beds, bool kitchen, bool shower, int floor, int number, string name, double price)
        {
            Available = true;
            Beds = beds;
            Kitchen = kitchen;
            Shower = shower;
            Floor = floor;
            Number = number;
            Name = name;
            Price = price;
        }

        public Rentable()
        {
            Available = true ;
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
            return "Laisvas: " + Available + " lovos: " + Beds + " virtuvė: " + Kitchen + " dušas: " + Shower + " Aukštas: " + Floor + " numeris: " + Number + "pavadinimas: " + Name
                 + " Kaina: " + Price;
        }
    }
 
}
