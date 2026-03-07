using Assesment_7March_Repository_Pattern.Models;

namespace Assesment_7March_Repository_Pattern.Repository
{
    public class MemoryBookRepository : IBookRepository
    {
        Dictionary<int, Book> _books = new Dictionary<int, Book>();
        public bool AddBook(Book book)
        {
            if(book == null)
            {
                throw new ArgumentNullException("The book cannot be null");
            }
            if(!_books.ContainsKey(book.BookId))
            {
                _books.Add(book.BookId, book);
                return true;
            }
            return false;
        }

        public bool DeleteBook(int id)
        {
            //throw new NotImplementedException();
            if(_books.ContainsKey(id))
            {
                _books.Remove(id);
                return true;
            }
            return false;
        }

        public ICollection<Book> GetAllBooks()
        {
            //throw new NotImplementedException();
            //List<Book> books = new List<Book>();
            //foreach(var book in _books.Values)
            //{
            //    books.Add(book);
            //}
            //return books;
            return _books.Values.ToList();
        }

        public Book GetBookById(int id)
        {
            if (_books.ContainsKey(id))
            {
                return _books[id];
            }
            return null;
            //throw new NotImplementedException();
        }
    }
}
