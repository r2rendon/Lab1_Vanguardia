using Core.Models;

namespace Lab1_API_Vanguardia.Services
{
    public class BooksService
    {
        public static List<Book> GetAvailableBooks()
        {
            // TODO: Use ORM to get authors
            var book = new Book();
            book.Name = "Tall tales";
            book.AvailableCopies = 123;
            book.PublishedAt = "2022-07-07";


            var book2 = new Book();
            book.Name = "Razonamiento logico";
            book.AvailableCopies = 5;
            book.PublishedAt = "1923-07-12";

            var authors = new List<Book> { book, book2 };
            return authors;
        }

        public static Book RegisterBook(Book author)
        {
            //TODO: Use ORM to insert author
            return author;
        }
    }
}
