using BasicAPIInterface.Domain.Models;

namespace BasicAPIInterface.Domain.Managers.Validators
{
    public class BookValidation : IBookValidation
    {
        public List<ValidationError> IsValid(Book book)
        {
            var validationErrors = new List<ValidationError>();
            if(string.IsNullOrWhiteSpace(book.Title))
                validationErrors.Add(new ValidationError{ Name = "Title", Description = "Title cannot be blank." });
            if (string.IsNullOrWhiteSpace(book.Author))
                validationErrors.Add(new ValidationError { Name = "Author", Description = "Author cannot be blank." });
            return validationErrors;
        }
    }
}
