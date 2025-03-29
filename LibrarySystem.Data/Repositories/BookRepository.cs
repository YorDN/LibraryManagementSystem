
using LibrarySystem.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        private readonly LibraryDbContext _context;
        public BookRepository(LibraryDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> GetBooksByAuthorAsync(string authorName)
        {
            return await _context.Books.Where(x => x.Author.Name == authorName).ToListAsync();
        }
    }
}
