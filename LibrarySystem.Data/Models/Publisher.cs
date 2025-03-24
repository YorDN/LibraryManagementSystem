
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    /// <summary>
    ///    This is the Publisher model, which represents a publisher in the LMS
    /// </summary>
    class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the publisher")]
        public required string Name { get; set; }

        [Required]
        [Comment("The logo of the publisher")]
        public required string Logo { get; set; }

        [Comment("The country of the publisher")]
        public string? Country { get; set; }

        [Comment("The website of the publisher")]
        public string? Website { get; set; }

        [Comment("A collection of the books published by the publisher")]
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
