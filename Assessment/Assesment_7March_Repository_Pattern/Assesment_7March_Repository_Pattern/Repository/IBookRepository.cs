using Assesment_7March_Repository_Pattern.Models;

namespace Assesment_7March_Repository_Pattern.Repository
{
    public interface IBookRepository
    {
        public ICollection<Book> GetAllBooks();
        public Book GetBookById(int id);
        
        public bool AddBook(Book book);
        public bool DeleteBook(int id);
    }
}
