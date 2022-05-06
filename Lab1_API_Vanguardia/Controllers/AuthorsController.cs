using Core.Models;
using Lab1_API_Vanguardia.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_API_Vanguardia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        [HttpGet()]
        public List<Author> Get()
        {
            return AuthorsService.GetAuthors();
        }

        [HttpPost]
        public Author Post([FromBody] Author author)
        {
            return AuthorsService.RegisterAuthor(author);
        }
    }
}
