using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiBiblioteca.Models;

namespace MiBiblioteca.Controllers
{
    public class BooksController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var book = new Book() { Name = "Book test"};
            
            return View(book);
        }

        [Route("books/released/{year}/{month}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
    }
}