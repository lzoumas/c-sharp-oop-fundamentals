using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() // default ctor, no params
            : this(0) // Constructor Chaining, calls the other ctr by passing a default value.
        {

        }

        public int CustomerType { get; set; }

        public Customer(int customerId)
        {
            this.CustomerId = customerId; // private setter, this - current instance
            this.AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; } // belongs to the instance itself and not to a specific Customer

        private string _lastName { get; set; } // use only when you need logic in the get or set
        public string LastName //Property
        {
            get
            {
                // Any code here
                return _lastName; // access when the code references the property
            }
            set
            {
                // Anu code here
                _lastName = value; // access when code assignes a value to the property
            }
        }

        public string FirstName { get; set; } // use only when you don't need logic within getter or setter

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; } // can read, but can only be set within class

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public List<Address> AddressList { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (!string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (!string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }

}
