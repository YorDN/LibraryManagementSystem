
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    /// <summary>
    ///    This is the Borrow model, which represents a book borrowed by a user in the LMS
    /// </summary>
    public class Borrow
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        [Comment("When was the book taken")]
        public DateOnly DateTaken { get; set; }

        [Comment("When does the book have to be returned")]
        public DateOnly DateDue { get; set; }

        [Comment("Is the book returned")]
        public bool Returned { get; set; }
    }
}
