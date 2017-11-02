using System.Collections.Generic;
using vidRent.Models;

namespace vidRent.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public List<Customer> Customers { get; set; }
        public Customer CustDetail { get; set; }
    }
}