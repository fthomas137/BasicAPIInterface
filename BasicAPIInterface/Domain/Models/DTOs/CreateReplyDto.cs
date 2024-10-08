namespace BasicAPIInterface.Domain.Models.DTOs
{
    public class CreateReplyDto
    {
        public int Id { get; set; }
        public List<ValidationError> ValidationErrors { get; set; } = new();
    }
}
