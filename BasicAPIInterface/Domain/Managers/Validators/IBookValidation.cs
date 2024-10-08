using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Validators
{
    public interface IBookValidation
    {
        List<ValidationError> IsValid(Book book);
    }
}
