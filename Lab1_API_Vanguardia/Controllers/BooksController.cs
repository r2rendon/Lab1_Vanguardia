using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Lab1_API_Vanguardia.Services;

namespace Lab1_API_Vanguardia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public List<Book> Get()
        {
            return BooksService.GetAvailableBooks();
        }

        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return BooksService.RegisterBook(book);
        }
    }
}
