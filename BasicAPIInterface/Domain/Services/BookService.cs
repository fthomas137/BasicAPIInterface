using BasicAPIInterface.Domain.Managers.Repositories;
using BasicAPIInterface.Domain.Managers.Validators;
using BasicAPIInterface.Domain.Models;
using BasicAPIInterface.Domain.Models.DTOs;

namespace BasicAPIInterface.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookValidation _bookValidation;
        private readonly IBooksRepo _booksRepo;

        public BookService(IBookValidation bookValidation, IBooksRepo booksRepo)
        {
            _bookValidation = bookValidation;
            _booksRepo = booksRepo;
        }

        public async Task<List<Book>> GetAll()
        {
            return await _booksRepo.GetAll();
        }

        public async Task<Book> GetById(int id)
        {
            return await _booksRepo.GetById(id);
        }

        public async Task<CreateReplyDto> Create(CreateBookRequest bookRequest)
        {
            var book = new Book()
            {
                Title = bookRequest.Title,
                Author = bookRequest.Author,
                HaveBook = bookRequest.HaveBook
            };
            var validationErrors = _bookValidation.IsValid(book);
            if (validationErrors.Count > 0)
            {
                return new CreateReplyDto()
                {
                    Id = 0,
                    ValidationErrors = validationErrors
                };
            }
            var result = await _booksRepo.Create(book);
            if (result == 0)
                return new CreateReplyDto
                {
                    Id = 0,
                    ValidationErrors = new List<ValidationError>
                    {
                        new ValidationError { Name = "", Description = "Error, book was not created." }
                    }
                };
            return new CreateReplyDto
            {
                Id = result,
                ValidationErrors = new List<ValidationError>()
            };
        }

        public async Task<List<ValidationError>> Update(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<ValidationError> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
