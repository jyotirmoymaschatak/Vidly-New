﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_New.Models;
using Vidly_New.ViewModels;

namespace Vidly_New.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Alpha Male!" };
            //ViewData["Movie"] = movie;
            var customer = new List<Customer>
            {
              new Customer {Name="Customer 1"},
              new Customer {Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        }

        //Get: Movies/Edit/1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // Get: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //Get Movies/released/2015/4
        [Route("Movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //Get Movies (Modified due to Hands On)
        public ActionResult Index()
        {

            var movie = new List<Movie>
            {
                new Movie {Name="Movie1"},
                new Movie {Name="Movie2"}
            };


            var viewModel = new RandomMovieViewModel
            {
                Movies = movie

            };

            return View(viewModel);


        }
    }
}