using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    #region Three Shipment Types : StandardShipment

    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        #region Constructor

        public StandardShipment(string TrackingCode) : base(TrackingCode) { }
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        #endregion

        #region Properties 

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }




        #endregion

        #region Methods

        public void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();

            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return "In Transit";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        #endregion
    }

    #endregion
}