using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiBiblioteca.Models;
using MiBiblioteca.ViewModels;

namespace MiBiblioteca.Controllers
{
    public class BooksController : Controller
    {
        // GET: Book/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Book test"};

            var customers = new List<Customer>
           {
               new Customer { Name = "Customer 1" },
               new Customer { Name = "Customer 2"}
           };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);
        }

        /*[Route("books/released/{year}/{month}/{month:regex(\\d{4}):range(1, 12}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
        
    }
}