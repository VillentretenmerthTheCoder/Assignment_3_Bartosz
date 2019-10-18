using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_1_Bartosz;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private static readonly List<Book> Books = new List<Book>()
        {
            new Book("Wiedzmin","Andrzej Sapkowski",456,"1234567891011"),
            new Book("Game of Thrones","J.R.R.Martin",650,"1213141516171"),
            new Book("How to do stuff","Orwell Adam",666,"8192021232425"),
            new Book("Greta Van Fleet","Adam Sanders",250,"2627282930313"),
            new Book("Led Zappelin","Jon Jonsen",789,"3233343537637")
        };

        // GET: api/Books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Books;
        }

        // GET: api/Books/5
        [HttpGet("{isbn13}", Name = "Get")]
        public Book Get(string Isbn13)
        {
            return Books.Find(i => i.Isbn13 == Isbn13);
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            Books.Add(value);
        }

        // PUT: api/Books/5
        [HttpPut("{isbn13}")]
        public void Put(string Isbn13, [FromBody] Book value)
        {
            Book book = Get(Isbn13);
            if (book != null)
            {
                book.Isbn13 = value.Isbn13;
                book.Title = value.Title;
                book.Author = value.Author;
                book.PageNumber = value.PageNumber;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{isbn13}")]
        public void Delete(string Isbn13)
        {
            Book book = Get(Isbn13);
            Books.Remove(book);
        }
    }
}
