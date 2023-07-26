namespace coreCodeFirstApproachProject.Models
{
    public class Author
    {
        // Scalar Properties
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        // Navigation Proprties
        public ICollection<Book>? Books { get; set; }
        public AuthorBiography? AuthorBiography { get; set; }
    }
}
