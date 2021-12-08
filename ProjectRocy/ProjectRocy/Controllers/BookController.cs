using Microsoft.AspNetCore.Mvc;
using ProjectRocy.Models;
using ProjectRocy.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRocy.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return _bookRepository.SearchBook(title, authorName);
        }



    }
}
