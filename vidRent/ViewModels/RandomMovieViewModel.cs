﻿using System.Collections.Generic;
using vidRent.Models;

namespace vidRent.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}