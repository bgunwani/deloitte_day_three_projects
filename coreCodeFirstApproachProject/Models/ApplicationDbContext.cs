using Microsoft.EntityFrameworkCore;

namespace coreCodeFirstApproachProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }


        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            *//* optionsBuilder.UseSqlServer("Server=DESKTOP-GEHPPMK;Database=deloittedb;User Id=sa;Password=123456");
            optionsBuilder.UseSqlServer("Server=DESKTOP-GEHPPMK;Database=deloittedb;integrated security=true;TrustServerCertificate=true"); */

            /*var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:SqlConnection"]);*//*

        }*/
    }
}
