using System.Data.Entity;

namespace MvcForAndy.Models
{
    public class TrackyContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
    }
}