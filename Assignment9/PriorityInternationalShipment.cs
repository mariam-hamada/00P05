using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        #region Constructor
        public PriorityInternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry,
        decimal customsFee)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination,
            destinationCountry,
            customsFee)
        {
        }
        #endregion

        #region Methods

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
            Console.WriteLine("Priority processing applied.");
        }

        #endregion
    }
}
