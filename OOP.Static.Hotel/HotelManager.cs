namespace OOP.Static.Hotel
{
    using System;
    using System.Collections.Generic;

    public interface IHotelManager
    {
        void AddHotel (Hotel h);
    }

    public class FileHotelManager : IHotelManager
    {
        public void AddHotel(Hotel h)
        {
            // write something to file
        }
    }

    public class HotelManager : IHotelManager
    {
        private static int nrInstances = 0;
        private static int nextHotelId = 0;

        public HotelManager()
        {
            this.Hotels = new List<Hotel>();

            nrInstances++;
        }

        public List<Hotel> Hotels { get; private set; }

        public void AddHotel (Hotel h)
        {
            h.Id = ++nextHotelId;
            this.Hotels.Add(h);
        }

        public static void PrintNrOfInstances()
        {
            Console.WriteLine($"Current nr of instances: {nrInstances}");
        }
    }
}