using Microsoft.EntityFrameworkCore;
using PaginationWebApi.Models;

namespace PaginationWebApi.Data
{
    public class PaginationContext : DbContext
    {
        public PaginationContext(DbContextOptions<PaginationContext> options) : base(options) { }

        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
