using System;

namespace OOP3.CarStore
{
    class Order : IOrder
    {
        public IPerson Person { get; set; }

        public IVehicle Vehicle { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
