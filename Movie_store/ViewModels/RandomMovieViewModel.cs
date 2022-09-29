using Movie_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_store.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}