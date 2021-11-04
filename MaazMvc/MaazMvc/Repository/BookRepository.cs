using MaazMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaazMvc.Repository
{
    public class BookRepository
    {
        public List<BookModel> getallbooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchbook(string title, string authorname)
        {
            return DataSource().Where(x => x.title.Contains(title) && x.author.Contains(authorname)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1 , title= "Mvc" , author = "maaz" },
                new BookModel(){Id = 2 , title= "java" , author = "ahmed" },
                new BookModel(){Id = 3 , title= "python" , author = "hamza" },
                new BookModel(){Id = 4 , title= "c#" , author = "yasir" },
                new BookModel(){Id = 5 , title= "c++" , author = "zubair" },
            };
        }
    }
}
