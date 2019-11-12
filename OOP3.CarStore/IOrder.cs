using System;

namespace OOP3.CarStore
{
    interface IOrder
    {
        IPerson Person { get; set; }

        IVehicle Vehicle { get; set; }

        DateTime DeliveryDate { get; set; }
    }
}
