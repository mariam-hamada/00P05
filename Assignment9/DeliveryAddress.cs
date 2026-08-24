using Assignment9;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    #region DeliveryAddress

    internal class DeliveryAddress
    {
        #region Attributes

        private string _city;
        private string _street;
        private int _buildingNumber;
        private Driver _driver;

        #endregion


        #region Properties

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int BuildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value; }
        }
        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }


        #endregion


        #region Constructor

        public DeliveryAddress(
                string city,
                string street,
                int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        #endregion


        #region Methods

        public string GetFullAddress()
        {
            return "The address is City: " + _city +
                   ", Street: " + _street +
                   ", Building Number: " + _buildingNumber;
        }

        #endregion
    }

    #endregion
}
