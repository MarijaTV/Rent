using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    class ReceptionControl
    {
        public static void printAllRooms(List<Rentable> rentables)
        {
            foreach (var rentable in rentables)
            {
                Console.WriteLine(rentable.ToString());
            }

        }
        public static void printAvailabeRooms(List<Rentable> rentables)
        {
            printAllRooms(rentables.Where(r => r.Availabe == true).ToList());
        }

    }
}
