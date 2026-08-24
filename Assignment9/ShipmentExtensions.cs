using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Assignment9
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            string shipmentType = shipment.GetType().Name.Replace("Shipment", "");

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {trackable.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            return trackable.GetTrackingStatus() == "Delivered";
        }
    }
}