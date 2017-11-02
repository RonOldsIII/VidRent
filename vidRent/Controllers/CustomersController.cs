using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidRent.Models;
using vidRent.ViewModels;
using static vidRent.Models.Customer;


namespace vidRent.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Cust1", Id = 1 });
            customers.Add(new Customer { Name = "Cust2", Id = 2 });
            customers.Add(new Customer { Name = "Cust3", Id = 3 });
            customers.Add(new Customer { Name = "Cust4", Id = 4 });

            var viewModel = new CustomerIndex
            {
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult Details(int id)
        {

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Cust1", Id = 1 });
            customers.Add(new Customer { Name = "Cust2", Id = 2 });
            customers.Add(new Customer { Name = "Cust3", Id = 3 });
            customers.Add(new Customer { Name = "Cust4", Id = 4 });
            
            var custDetail = customers.FirstOrDefault(c => c.Id == id);

            var viewModel = new CustomerDetailsViewModel    
            {
                CustDetail = custDetail,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}