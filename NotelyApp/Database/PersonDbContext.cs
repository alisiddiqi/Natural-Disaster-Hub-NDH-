using Microsoft.EntityFrameworkCore;
using NotelyApp.Models;

namespace NotelyApp.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext (DbContextOptions<PersonDbContext> options) : base(options){}

        public DbSet<PersonModel> Persons { get; set; }
    }
}
