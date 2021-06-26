using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {

            Rentable room1 = new Rentable(3, true, true, 2, 201, "Vila Marija1", 68);
            Rentable room2 = new Rentable(4, true, false, 3, 301, "Vila Irena2", 65);
            Rentable room3 = new Rentable(3, false, true, 4, 401, "Vila Marija3", 38);
            Rentable room4 = new Rentable(2, true, true, 2, 202, "Vila Irena4", 39);
            Rentable room5 = new Rentable(5, true, false, 3, 302, "Vila Marija5", 78);
            Rentable room6 = new Rentable(4, true, true, 1, 101, "Vila Irena6", 25);
            Rentable room7 = new Rentable(3, false, true, 2, 203, "Vila Marija7", 38);
            Rentable room8 = new Rentable(2, true, false, 3, 303, "Vila Irena8", 57);
            Rentable room9 = new Rentable(5, true, false, 4, 402, "Vila Marija9", 112);
            Rentable room10 = new Rentable(4, false, true, 1, 102, "Vila Irena10", 58);
            Rentable room11 = new Rentable(3, true, true, 2, 204, "Vila Marija11", 69);
            Rentable room12 = new Rentable(4, true, false, 3, 304, "Vila Irena12", 74);
            Rentable room13 = new Rentable(3, false, true, 4, 403, "Vila Marija13", 84);
            Rentable room14 = new Rentable(4, false, true, 2, 205, "Vila Irena14", 95);

            List<Rentable> hotel = new List<Rentable>();
            hotel.Add(room1);
            hotel.Add(room2);
            hotel.Add(room3);
            hotel.Add(room4);
            hotel.Add(room5);
            hotel.Add(room6);
            hotel.Add(room7);
            hotel.Add(room8);
            hotel.Add(room9);
            hotel.Add(room10);
            hotel.Add(room11);
            hotel.Add(room12);
            hotel.Add(room13);
            hotel.Add(room14);

            Rentable smallHouse1 = new Rentable(1, true, true, 1, 106, "106", 55);
            Rentable smallHouse2 = new Rentable(2, true, false, 1, 107, "107", 55);
            Rentable smallHouse3 = new Rentable(1, false, true, 1, 108, "108", 55);
            Rentable smallHouse4 = new Rentable(2, true, true, 1, 109, "109", 55);
            Rentable smallHouse5 = new Rentable(3, true, false, 1, 110, "110", 55);
            Rentable smallHouse6 = new Rentable(1, true, true, 1, 111, "111", 55);
            Rentable smallHouse7 = new Rentable(3, false, true, 1, 112, "117", 55);
            Rentable smallHouse8 = new Rentable(2, true, false, 1, 113, "118", 55);

            List<Rentable> smallHauses = new List<Rentable>();
            smallHauses.Add(smallHouse1);
            smallHauses.Add(smallHouse2);
            smallHauses.Add(smallHouse3);
            smallHauses.Add(smallHouse4);
            smallHauses.Add(smallHouse5);
            smallHauses.Add(smallHouse6);
            smallHauses.Add(smallHouse7);
            smallHauses.Add(smallHouse8);


            while (true)
            {
                Console.WriteLine("What to do? x- means number");
                Console.WriteLine("1 - All rooms");
                Console.WriteLine("1l - All available houses");
                Console.WriteLine("2 - All small houses");
                Console.WriteLine("2l - All available small houses");
                Console.WriteLine("3-x - all rooms on x floor");
                Console.WriteLine("3l-x - all available rooms on x floor");
                Console.WriteLine("rn- book smallhouse");
                Console.WriteLine("rk- book room");

                string input = Console.ReadLine();
                int num = 0;
                if (input.Contains ("3-"))
                {
                    num = int.Parse(input.Substring(2));
                    input = "3";
                }
                if (input.Contains("3l-"))
                {
                    num = int.Parse(input.Substring(3));
                    input = "3l";
                }
                switch (input)
                {
                    case "1":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    case "1l":
                        ReceptionControl.printAvailableRooms(hotel);
                        break;
                    case "2":
                        ReceptionControl.printAllRooms(smallHauses);
                        break;
                    case "2l":
                        ReceptionControl.printAvailableRooms(smallHauses);
                        break;
                    case "3":
                        Console.WriteLine("3 + " + num);
                        ReceptionControl.printFloorRooms(hotel, num);
                        break;
                    case "3l":
                        Console.WriteLine("3l + " + num);
                        ReceptionControl.printAvailableFloorRooms(hotel, num);
                        break;
                    case "rn":
                        ReceptionControl.reserveRoom(hotel);
                        break;
                    case "rk":
                        ReceptionControl.reserveRoom(smallHauses);
                        break;
                    default:
                        Console.WriteLine("Įveskite teisingus duomenis");
                        break;
                }

            }
        }
        
    }
}
