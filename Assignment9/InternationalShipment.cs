using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {

        #region Attributes

        private string _destinationCountry;
        private decimal _customsFee;

        #endregion


        #region Properties

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                    _customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        #endregion


        #region Constructor

        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customFee;
        }

        #endregion


        #region Methods
        public  void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();

            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Description         : {Description}");
            Console.WriteLine($"Weight              : {Weight} KG");
            Console.WriteLine($"Delivery Fee        : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }


        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }

        public string GetTrackingStatus()
        {
            return "Delivered";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        #endregion
    }
}
