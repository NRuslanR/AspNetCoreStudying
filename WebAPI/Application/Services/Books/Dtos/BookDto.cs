namespace WebAPI.Application.Services.Books.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublishingYear { get; set; }
    }
}