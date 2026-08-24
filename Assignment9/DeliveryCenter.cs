using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    #region DeliveryCenter

    internal class DeliveryCenter
    {
        #region Attributes

        private Shipment[] shipments = new Shipment[20];
        private string _centerName;
        private Driver _driver;

        #endregion


        #region Properties


        public string CenterName
        {
            get { return _centerName; }
            set { _centerName = value; }
        }

        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        #endregion


        #region Indexers

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode.Equals(
                            trackingCode,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        #endregion


        #region Methods

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }


        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode.Equals(
                        trackingCode,
                        StringComparison.OrdinalIgnoreCase))
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }


        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    Console.WriteLine(
                        $"The details of Shipment {i + 1} is:");

                    shipments[i].PrintShipment();

                    Console.WriteLine("-------------------------------------");
                }
            }
        }

        public void PrintTrackingStatuses()
        {

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }



        #endregion
    }

    #endregion
}