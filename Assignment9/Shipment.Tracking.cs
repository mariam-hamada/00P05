using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal partial class Shipment
    {
        #region Tracking

        private string _trackingStatus = "In Transit";

        public string TrackingStatus
        {
            get { return _trackingStatus; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingStatus = value;
            }
        }

        public virtual string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;
                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }

        #endregion
    }
}
