﻿
using Aplikacija1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacija1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}