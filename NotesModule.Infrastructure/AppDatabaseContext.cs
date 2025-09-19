using Microsoft.EntityFrameworkCore;
using NotesModule.Domain.Entities;

namespace NotesModule.Domain
{
  public  class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options)
           : base(options)
        {

        }
        public DbSet<NotesModel>? Notes { get; set; }
    }
}
