
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the author")]
        public required string Name { get; set; }

        [Required]
        [Comment("The photo of the author")]
        public required string Photo { get; set; }

        [Comment("The biography of the author")]
        // When was the author born, where, what are some of the most important works, etc.
        public string? Biography { get; set; }

        [Comment("A collection of the books written by the author")]
        ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
