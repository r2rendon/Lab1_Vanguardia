using Core.Models;

namespace Lab1_API_Vanguardia.Services
{
    public class AuthorsService
    {
        public static List<Author> GetAuthors()
        {
            // TODO: Use ORM to get authors
            var author = new Author();
            author.Name = "Arturo Rendon";
            author.Age = 21;

            var author2 = new Author();
            author.Name = "Guillermo Robles";
            author.Age = 32;

            var authors = new List<Author> { author, author2 };
            return authors;
        }

        public static Author RegisterAuthor(Author author)
        {
            //TODO: Use ORM to insert author
            return author;
        }
    }
}
