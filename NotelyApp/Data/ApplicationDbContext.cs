using Microsoft.EntityFrameworkCore;
using NotelyApp.Models;

namespace NotelyApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PersonModel> PersonModel { get; set; }
    }
}
