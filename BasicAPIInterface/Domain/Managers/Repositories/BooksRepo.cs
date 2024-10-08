using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Repositories
{
    public class BooksRepo : IBooksRepo
    {
        private List<Book> books = new List<Book>();

        public async Task<List<Book>> GetAll()
        {
            return await Task.Run(() =>
            {
                return books;
            });
        }

        public async Task<Book?> GetById(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public async Task<int> Create(Book book)
        {
            var newId = books.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();
            book.Id = (int)newId + 1;
            books.Add(book);
            return book.Id;
        }

        public async Task<bool> Update(Book book)
        {
            var oldBook = books.FirstOrDefault(x => x.Id == book.Id);
            if (oldBook == null)
                return false;
            oldBook.Title = book.Title;
            oldBook.Author = book.Author;
            oldBook.HaveBook = book.HaveBook;
            oldBook.DateUpdated = DateTime.Today;
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book == null) return false;
            books.Remove(book);
            return true;
        }
    }
}
