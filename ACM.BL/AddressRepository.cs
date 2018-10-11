using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bad End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            var address =  new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bad End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address customer)
        {
            return true;
        }
    }
}
