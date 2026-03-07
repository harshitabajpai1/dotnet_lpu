
using Assesment_7March_Repository_Pattern.DatabaseContext;
using Assesment_7March_Repository_Pattern.Models;

namespace Assesment_7March_Repository_Pattern.Repository
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public SqlBookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public ICollection<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public bool AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return false;

            _context.Books.Remove(book);
            _context.SaveChanges();

            return true;
        }
    }
}