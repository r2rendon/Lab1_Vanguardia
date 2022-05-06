using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace Lab1_API_Vanguardia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public Book Get()
        {
            var book = new Book();
            book.Name = "Aventuras de Arturo";
            book.PublishedAt = "2022-07-07";
            book.AvailableCopies = 11200;
            return book;
        }

        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return book;
        }
    }
}
