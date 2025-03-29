

using LibrarySystem.Data.Repositories;

namespace LibrarySystem.Service.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

    }
}
