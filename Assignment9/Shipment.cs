using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal class Shipment
    {
        #region Attributes

        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;
        public static int TotalShipmentsCreated = 0;

        #endregion


        #region Properties

        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public virtual decimal EstimatedCost { get; }

        #endregion


        #region Constructors

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Cairo", "Tahrir", 10);
            TotalShipmentsCreated++;
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }

         static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        #endregion


        #region Methods

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            decimal totalWeight = newWeight + extraPackingWeight;

            if (totalWeight > 0)
                Weight = totalWeight;
        }
        public virtual void PrintShipment()
        {

            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public Shipment CopyShipment()
        {
            return new Shipment(
                this.TrackingCode,
                this.Description,
                this.Weight,
                this.DeliveryFee,
                this.Destination);
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            return new Shipment(
                this.TrackingCode,
                this.Description,
                this.Weight,
                this.DeliveryFee,
                new DeliveryAddress(
                    this.Destination.City,
                    this.Destination.Street,
                    this.Destination.BuildingNumber)
                );
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        #endregion
        }
}
