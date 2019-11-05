using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager1 = new HotelManager();
            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 1" });
            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 3" });

            var manager2 = new HotelManager();
            manager2.AddHotel(new Hotel { Name = "Suceava Hotel 2" });

            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 100" });

            manager2.AddHotel(new Hotel { Name = "Suceava Hotel 200" });

            HotelManager.PrintNrOfInstances();
            HotelManager.PrintNrOfInstances();

            int y = HotelManager.NrInstances;
            int x = HotelManager.NextHotelId;
        }
    }

    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class HotelManager
    {
        public static int NrInstances = 0;
        public static int NextHotelId = 0;

        public HotelManager()
        {
            Hotels = new List<Hotel>();

            NrInstances++;
        }

        public List<Hotel> Hotels { get; private set; }

        public void AddHotel (Hotel h)
        {
            h.Id = ++NextHotelId;
            Hotels.Add(h);
        }

        public static void PrintNrOfInstances()
        {
            Console.WriteLine($"Current nr of instances: {NrInstances}");
        }
    }
}
