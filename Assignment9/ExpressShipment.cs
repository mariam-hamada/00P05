using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{

    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        #region Attributes

        private decimal _extraFee;

        #endregion


        #region Properties

        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                    _extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        #endregion


        #region Constructor

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            ExtraFee = extraFee;
        }

        #endregion


        #region Methods


        public  void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();

            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is out for delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        #endregion
    }
}