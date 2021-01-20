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
        public ActionResult Random()
        {
            var book = new Book() { Name = "Book test"};
            
            return View(book);
        }
    }
}