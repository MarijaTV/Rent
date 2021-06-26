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
        public static void printAvailableRooms(List<Rentable> rentables)
        {
            printAllRooms(rentables.Where(r => r.Available == true).ToList());
        }

        public static void printFloorRooms(List<Rentable> rentables, int num)
        {
            printAllRooms(rentables.Where(r => r.Floor == num).ToList());
        }

        public static void printAvailableFloorRooms(List<Rentable> rentables, int num)
        {
            printAvailableRooms(rentables.Where(r => r.Floor == num).ToList());
        }

        public static void reserveRoom(List<Rentable> rentables)
        {
            int num = int.Parse(Console.ReadLine());
            rentables.Where(r => r.Available == true).Where(r => r.Number == num).First().Available = false;
            Console.WriteLine(num + " Reserved successfully!");

        }

    //    int num = 0;
    //        try
    //        {
    //             num = int.Parse(Console.ReadLine());
    //}catch(Exception e)
    //        {
               
    //        }

    }
}
