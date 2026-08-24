using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal class DeliveryReport
    {

        #region Methods

        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance():F}");
        }

        #endregion

    }
}
