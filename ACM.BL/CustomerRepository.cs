using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository AddressRepository { get; set; }

        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList(); // collaborative relationship between Address and CustomerRepository

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
