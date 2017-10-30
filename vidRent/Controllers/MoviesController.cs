using System.Collections.Generic;
using System.Web.Mvc;
using vidRent.Models;
using vidRent.ViewModels;

namespace vidRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "cust 1"},
                new Customer {Name = "cust 2"},
                new Customer {Name = "cust 3"},
                new Customer {Name = "cust 4"},
                new Customer {Name = "cust 5"},
                new Customer {Name = "cust 6"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

        return View(viewModel);
        }
    }
}