namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;

    public class HotelManager
    {
        public static int NrInstances = 0;
        public static int NextHotelId = 0;

        public HotelManager()
        {
            this.Hotels = new List<Hotel>();

            NrInstances++;
        }

        public List<Hotel> Hotels { get; private set; }

        public void AddHotel (Hotel h)
        {
            h.Id = ++NextHotelId;
            this.Hotels.Add(h);
        }

        public static void PrintNrOfInstances()
        {
            Console.WriteLine($"Current nr of instances: {NrInstances}");
        }
    }
}