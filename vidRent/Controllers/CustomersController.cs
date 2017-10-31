using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidRent.Models;

namespace vidRent.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "cust 1",
                    Id = 1
                },
                new Customer
                {
                    Name = "cust 2",
                    Id = 2
                },
            };
            return View();
        }
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "cust 1",
                    Id = 1
                },
                new Customer
                {
                    Name = "cust 2",
                    Id = 2
                },
            };
            return View();
        }


    }
}