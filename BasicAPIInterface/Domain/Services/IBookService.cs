using BasicAPIInterface.Domain.Models;
using BasicAPIInterface.Domain.Models.DTOs;

namespace BasicAPIInterface.Domain.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
        Task<Book> GetById(int id);
        Task<CreateReplyDto> Create(CreateBookRequest request);
        Task<List<ValidationError>> Update(Book book);
        Task<ValidationError> Delete(int id);
    }
}
