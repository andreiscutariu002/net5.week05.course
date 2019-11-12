namespace OOP3.CarStore
{
    interface IVehicle
    {
        IProducer Producer { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }
    }
}
