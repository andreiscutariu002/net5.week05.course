namespace OOP.Static.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            IHotelManager manager1 = new HotelManager();

            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 1" });
            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 3" });

            IHotelManager manager2 = new HotelManager();
            manager2.AddHotel(new Hotel { Name = "Suceava Hotel 2" });

            manager1.AddHotel(new Hotel { Name = "Iasi Hotel 100" });

            manager2.AddHotel(new Hotel { Name = "Suceava Hotel 200" });

            //HotelManager.PrintNrOfInstances();
            //HotelManager.PrintNrOfInstances();
        }
    }
}
