using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCoast
{
    class Customer
    {
        private int customerID;
        private String title;
        private String forename;
        private String surname;
        private String addressLine1;
        private String addressLine2;
        private String town;
        private String postcode;
        private String telNo;
        private String mobNo;
        private String email;
        private DateTime dateOfBirth;
        private int newsletterSubscription;

        public Customer()
        {
            customerID = 0;
            title = null;
            forename = null;
            surname = null;
            addressLine1 = null;
            addressLine2 = null;
            town = null;
            postcode = null;
            telNo = null;
            mobNo = null;
            email = null;
            dateOfBirth = DateTime.Now;
            newsletterSubscription = 0;
        }

        public Customer(int customerID, String title, String forename, String surname, String addressLine1, String addressLine2, String town, String postcode, String telNo, String mobNo, String email, DateTime dateOfBirth, int newsletterSubscription)
        {
            CustomerID = customerID;
            Title = title;
            Forename = forename;
            Surname = surname;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Town = town;
            Postcode = postcode;
            TelNo = telNo;
            MobNo = mobNo;
            Email = email;
            DateOfBirth = dateOfBirth;
            NewsletterSubscription = newsletterSubscription;
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

        public String Title
        {
            get { return title; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validTitle(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    title = value;
            }
        }

        public String Forename
        {
            get { return forename; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validString(str, 3, 20);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    forename = value;
            }
        }

        public String Surname
        {
            get { return surname; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validString(str, 3, 20);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    surname = value;
            }
        }

        public String AddressLine1
        {
            get { return addressLine1; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                if (validAddressLine(str, 5, 50).CompareTo("ok") != 0)
                    throw new CustomerException("Please enter an address between 5 and 50 characters");
                else
                    addressLine1 = value;
            }
        }

        public String AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        public String Town
        {
            get { return town; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validString(str, 3, 20);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    town = value;
            }
        }

        public String Postcode
        {
            get { return postcode; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validPostcode(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    postcode = value;
            }
        }

        public String TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public String MobNo
        {
            get { return mobNo; }
            set { mobNo = value; }
        }

        public String Email
        {
            get { return email; }
            set
            {
                //implement validation / throw new exception
                String str = value;
                String validStringError = validEmail(str);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    email = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                //implement validation / throw new exception
                DateTime date = value;
                String validStringError = validDateOfBirth(date);
                if (validStringError.CompareTo("ok") != 0)
                    throw new CustomerException(validStringError);
                else
                    dateOfBirth = value;
            }
        }

        public int NewsletterSubscription
        {
            get { return newsletterSubscription; }
            set { newsletterSubscription = value; }
        }

        public String toString()
        {    //basic - extend for all fields
            return String.Format("\n {0:d4}  {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13}", customerID, forename, surname, addressLine1, addressLine2, town, postcode, telNo, mobNo, email, dateOfBirth, newsletterSubscription);
        }

        private String validString(String str, int min, int max)
        {
            String message = "ok";
            char[] specialChars = "!£$%^&*()_+={}[]#~@;:/.>,<".ToCharArray();
            int strIndex = str.IndexOfAny(specialChars);

            if (String.IsNullOrEmpty(str))
            {
                message = "This is a required field - Please enter data";
            }
            else if (str.Length < min || str.Length > max)
            {
                message = "Must have minimum of " + min + " chars and a maximum of " + max;
            }
            else if (str.Any(char.IsDigit) || strIndex != -1)
            {
                message = "Must not contain any digits or special characters e.g. !£$%^&*()_+={}[]#~@;:/.>,<";
            }

            return message;
        }

        private String validAddressLine(String str, int min, int max)
        {
            String message = "ok";
            char[] specialChars = "!£$%^&*()_+={}[]#~@;:/.>,<".ToCharArray();
            int strIndex = str.IndexOfAny(specialChars);

            if (String.IsNullOrEmpty(str))
            {
                message = "This is a required field - Please enter data";
            }
            else if (str.Length < min || str.Length > max)
            {
                message = "Must have minimum of " + min + " chars and a maximum of " + max;
            }
            else if (strIndex != -1)
            {
                message = "Must not contain any special characters e.g. !£$%^&*()_+={}[]#~@;:/.>,<";
            }

            return message;
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

        private String validTitle(String str)
        {
            //validating size of data

            String message = "ok";
            String[] titles = { "Ms", "Mr", "Mrs", "Miss", "Dr" };

            if (String.IsNullOrEmpty(str))
            {
                message = "Please select a title";
            }
            else if (!titles.Any(str.Contains))
            {
                message = "Title must be from this list: Ms Mr Mrs Miss Dr";
            }

            return message;
        }

        private String validPostcode(String str)
        {
            //validating size of data

            String message = "ok";
            char[] specialChars = "!£$%^&*()_+={}[]#~@;:/.>,<".ToCharArray();
            int strIndex = str.IndexOfAny(specialChars);

            if (String.IsNullOrEmpty(str))
            {
                message = "This is a required field - You must enter data";
            }
            else if (!str.Contains(" ") && str.Length != 8 && strIndex != -1)
            {
                message = "Postcode must be 8 characters long, contain a space and no specials characters e.g. BT23 6QQ";
            }

            return message;
        }

        private String validEmail(String str)
        {
            //validating size of data

            String message = "ok";
            char[] specialChars = " [];:".ToCharArray();
            int strIndex = str.IndexOfAny(specialChars);

            if (String.IsNullOrEmpty(str))
            {
                message = "This is a required field - You must enter data";
            }
            else if (str.Length < 6 || str.Length > 30)
            {
                message = "Email Address must be between 6 and 30 characters";
            }
            else if (!str.Contains("@") || !str.Contains(".") || (strIndex != -1))
            {
                message = @"Email Address must contain a ""."" and ""@"" e.g. downhigh123@c2kni.net";
            }

            return message;
        }

        private String validDateOfBirth(DateTime date)
        {
            String message = "ok";

            if (date.AddYears(18).Date >= DateTime.Now.Date)
            {
                message = "Date must not be before todays date";
            }

            return message;
        }
    }
}
