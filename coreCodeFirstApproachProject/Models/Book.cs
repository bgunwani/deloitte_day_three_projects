namespace coreCodeFirstApproachProject.Models
{
    public class Book
    {
        // Scalar Properties
        public int BookId { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        // Navigation Properties
        public Author? Author { get; set; }
    }
}
