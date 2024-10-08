namespace BasicAPIInterface.Domain.Models.DTOs
{
    public class CreateBookRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public bool HaveBook { get; set; }
    }
}
