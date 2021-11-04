using MaazMvc.Models;
using MaazMvc.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaazMvc.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly BookRepository _bookRepository =  null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> getallbooks()
        {
            return _bookRepository.getallbooks ();
        }

        public BookModel getbook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> searchbooks(string bookname, string authorname)
        {
            return _bookRepository.searchbook(bookname , authorname);
        }
    }
}
