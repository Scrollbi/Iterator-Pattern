using System.Collections;

namespace Iterator_Pattern
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }
        
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return _books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
