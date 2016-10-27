using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCoast
{
    class CustomerBooking
    {
        private int customerID;
        private String locationID;
        private DateTime arrivalDate;
        private String noOfNights;
        private DateTime dateOfBooking;
        private int depositPaid;
        private String noOfPeople;
        private int electric;
        private int water;
        private int checkedIn;
        private int checkedOut;
        private int bookingPaid;
        private String accommodationType;

        public CustomerBooking()
        {
            customerID = 0;
            locationID = null;
            arrivalDate = DateTime.Now.AddDays(-1);
            noOfNights = null;
            dateOfBooking = DateTime.Now.AddDays(-1);
            depositPaid = 0;
            noOfPeople = null;
            electric = 0;
            water = 0;
            checkedIn = 0;
            checkedOut = 0;
            bookingPaid = 0;
            accommodationType = null;
        }

        public CustomerBooking(int customerID, String locationID, DateTime arrivalDate, String noOfNights, DateTime dateOfBooking, int depositPaid, String noOfPeople, int electric, int water, int checkedIn, int checkedOut, int bookingPaid, String accommodationType)
        {
            CustomerID = customerID;
            LocationID = locationID;
            ArrivalDate = arrivalDate;
            NoOfNights = noOfNights;
            DateOfBooking = dateOfBooking;
            DepositPaid = depositPaid;
            NoOfPeople = noOfPeople;
            Electric = electric;
            Water = water;
            CheckedIn = checkedIn;
            CheckedOut = checkedOut;
            BookingPaid = bookingPaid;
            AccommodationType = accommodationType;
        }

        public int CustomerID
        {
            get { return customerID; }
            set
            {
                int testInt = value;
                if (validCustomerID(testInt, 1000, 9999).CompareTo("ok") != 0)
                    throw new CustomerException("CustomerID must be between 1000 and 9999");
                else
                    customerID = value;
            }
        }

        public String LocationID
        {
            get { return locationID; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validLocationID(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    locationID = value;
            }
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public String NoOfNights
        {
            get { return noOfNights; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validNoOfPeople(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    noOfNights = value;
            }
        }

        public DateTime DateOfBooking
        {
            get { return DateOfBooking; }
            set { dateOfBooking = value; }
        }

        public int DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }

        public String NoOfPeople
        {
            get { return noOfPeople; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validNoOfPeople(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    noOfPeople = value;
            }
        }

        public int Electric
        {
            get { return electric; }
            set { electric = value; }
        }

        public int Water
        {
            get { return water; }
            set { water = value; }
        }

        public int CheckedIn
        {
            get { return checkedIn; }
            set { checkedIn = value; }
        }

        public int CheckedOut
        {
            get { return checkedOut; }
            set { checkedOut = value; }
        }

        public int BookingPaid
        {
            get { return bookingPaid; }
            set { bookingPaid = value; }
        }

        public String AccommodationType
        {
            get { return accommodationType; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validAccommodationType(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    accommodationType = value;
            }
        }

        public String toString()
        {    //basic - extend for all fields
            return String.Format("\n {0:d4}  {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", customerID, locationID, arrivalDate, noOfNights, dateOfBooking, depositPaid, noOfPeople, electric, water, checkedIn, checkedOut, bookingPaid, accommodationType);
        }

        private String validCustomerID(int number, int min, int max)
        {
            //validating size of data

            String message = "ok";

            if ((number < min) || (number > max))
            {
                message = "Please enter a value between " + min + " and " + max;
            }

            return message;
        }

        private String validLocationID(String str)
        {
            String message = "ok";

            if (String.IsNullOrEmpty(str))
            {
                message = "LocationID is a required field - You must enter data";
            }
            else if (str.Length != 4)
            {
                message = "LocationID must be 4 characters in length";
            }
            else if (str.Substring(0, 1) != "L" || !str.Substring(1, 3).All(char.IsDigit))
            {
                message = @"LocationID must conatin an ""L"" and then a three digit number e.g. ""L001""";
            }

            return message;
        }

        private String validNoOfNights(String str)
        {
            String message = "ok";

            if (String.IsNullOrEmpty(str))
            {
                message = "Number of nights is a required field - Please select either a number or indefinate";
            }

            return message;
        }

        private String validNoOfPeople(String str)
        {
            String message = "ok";

            if (String.IsNullOrEmpty(str))
            {
                message = "Please Select the number of people that will be staying";
            }
            /*else if ((int.Parse(str) < 2) || (int.Parse(str) > 8))
            {
                message = "Please slect a number between 2 and 8";
            }*/

            return message;
        }

        private String validAccommodationType(String str)
        {
            String message = "ok";

            if (String.IsNullOrEmpty(str))
            {
                message = "Please Select the type of accommodation that you will be staying in";
            }

            return message;
        }
    }
}
