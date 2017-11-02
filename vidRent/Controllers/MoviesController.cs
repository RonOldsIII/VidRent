using System.Collections.Generic;
using System.Web.Mvc;
using vidRent.Models;
using vidRent.ViewModels;

namespace vidRent.Controllers
{
    public class MoviesController : Controller
    {


        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Id = 1, Name = "Shrek"});
            movies.Add(new Movie { Id = 2, Name = "The Matrix" });

            var viewModel = new MoviesIndex
            {
                Movies = movies
            };


            return View(viewModel);
            
        }

        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "cust 1"},
                new Customer {Name = "cust 2"},

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