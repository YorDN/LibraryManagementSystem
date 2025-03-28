
using LibrarySystem.Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data
{
    public class LibraryDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> dbContextOptions) 
            :base(dbContextOptions)
        {
            
        }
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Borrow> Borrows { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Quote> Quotes { get; set; }
    } 
}
