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
            string trackingStatus = ((ITrackable)shipment).GetTrackingStatus();

            return $"{shipment.TrackingCode} | {shipment.GetType().Name.Replace("Shipment", "")} | {shipment.Weight} KG | {trackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            return trackable.GetTrackingStatus() == "Delivered";
        }
    }
}