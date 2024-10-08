using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Repositories
{
    public interface IBooksRepo
    {
        Task<List<Book>> GetAll();
        Task<Book?> GetById(int id);
        Task<int> Create(Book book);
        Task<bool> Update(Book book);
        Task<bool> Delete(int id);
    }
}
