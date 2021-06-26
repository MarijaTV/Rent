using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {

            Rentable room1 = new Rentable(3, true, true, 2, "Vila Marija1", 68);
            Rentable room2 = new Rentable(4, true, false, 2, "Vila Irena2", 65);
            Rentable room3 = new Rentable(3, false, true, 2, "Vila Marija3", 38);
            Rentable room4 = new Rentable(2, true, true, 2, "Vila Irena4", 39);
            Rentable room5 = new Rentable(5, true, false, 2, "Vila Marija5", 78);
            Rentable room6 = new Rentable(4, true, true, 2, "Vila Irena6", 25);
            Rentable room7 = new Rentable(3, false, true, 2, "Vila Marija7", 38);
            Rentable room8 = new Rentable(2, true, false, 2, "Vila Irena8", 57);
            Rentable room9 = new Rentable(5, true, false, 2, "Vila Marija9", 112);
            Rentable room10 = new Rentable(4, false, true, 2, "Vila Irena10", 58);
            Rentable room11 = new Rentable(3, true, true, 2, "Vila Marija11", 69);
            Rentable room12 = new Rentable(4, true, false, 2, "Vila Irena12", 74);
            Rentable room13 = new Rentable(3, false, true, 2, "Vila Marija13", 84);
            Rentable room14 = new Rentable(4, false, true, 2, "Vila Irena14", 95);

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

            Rentable smallHouse1 = new Rentable(1, true, true, 1, "106", 55);
            Rentable smallHouse2 = new Rentable(2, true, false, 1, "107", 55);
            Rentable smallHouse3 = new Rentable(1, false, true, 1, "108", 55);
            Rentable smallHouse4 = new Rentable(2, true, true, 1, "109", 55);
            Rentable smallHouse5 = new Rentable(3, true, false, 1, "110", 55);
            Rentable smallHouse6 = new Rentable(1, true, true, 1, "111", 55);
            Rentable smallHouse7 = new Rentable(3, false, true, 1, "117", 55);
            Rentable smallHouse8 = new Rentable(2, true, false, 1, "118", 55);

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
                Console.WriteLine(input);
                switch (input)
                {
                    case "1":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    case "1l":
                        ReceptionControl.printAvailabeRooms(hotel);
                        break;
                    case "2":
                        ReceptionControl.printAllRooms(smallHauses);
                        break;
                    case "2l":
                        ReceptionControl.printAvailabeRooms(smallHauses);
                        break;
                    case "3-x":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    case "3l-x":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    case "rn":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    case "rk":
                        ReceptionControl.printAllRooms(hotel);
                        break;
                    default:
                        Console.WriteLine("Įveskite teisingus duomenis");
                        break;
                }

            }
        }
        
    }
}
