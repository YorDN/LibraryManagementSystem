
using LibrarySystem.Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data
{
    class LibraryDbContext : IdentityDbContext<User, IdentityRole<int>, int>
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
    } 
}
