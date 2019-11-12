namespace OOP3.CarStore
{

    class Program
    {
        static void Main(string[] args)
        {
            IPerson alex = new Client { Name = "Alex" };

            IStore ford = new Store("Ford");
            IVehicle focus = new Vehicle
            {
                Name = "Focus",
                Price = 15000,
                Producer = new Producer { Name = "Ford" }
            };

            IStore skoda = new Store("Skoda");
            IVehicle fabia = new Vehicle
            {
                Name = "Fabia",
                Price = 14000,
                Producer = new Producer { Name = "Skoda" }
            };

            IOrder focusOrder = ford.EnterAndMakeOrder(alex, focus);

            IOrder skodaOrder = skoda.EnterAndMakeOrder(alex, fabia);

            if(focusOrder.DeliveryDate < skodaOrder.DeliveryDate)
            {
                skoda.CancelOrder(skodaOrder);
            }
            else
            {
                ford.CancelOrder(focusOrder);
            }
        }
    }
}
