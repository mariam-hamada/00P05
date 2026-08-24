using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    internal class Driver
    {

        #region Attributes

        private int _driverId;
        private string _fullName;
        private string _phoneNumber;

        #endregion

        #region Properties

        public int DriverId
        {
            get { return _driverId; }
            set { _driverId = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        #endregion

        #region Constructor 

        public Driver(int driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        #endregion
    }
}
