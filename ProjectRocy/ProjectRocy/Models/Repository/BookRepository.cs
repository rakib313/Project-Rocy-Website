using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRocy.Models.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.ToLower().Contains(title.ToLower()) || x.Author.ToLower().Contains(authorName.ToLower())).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1, Title="MVC", Author="Rakib" },
                new BookModel() { Id=1, Title="MVC", Author="Rocy" },
                new BookModel() { Id=1, Title="C#", Author="Sahadat" },
                new BookModel() { Id=1, Title="PHP", Author="Sohel" },
                new BookModel() { Id=1, Title="Java", Author="Sakib" },
            };
        }
    }
}
