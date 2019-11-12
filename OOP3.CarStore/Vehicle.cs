namespace OOP3.CarStore
{
    class Vehicle : IVehicle
    {
        public IProducer Producer { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
