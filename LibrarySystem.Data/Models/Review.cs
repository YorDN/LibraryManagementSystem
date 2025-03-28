

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    /// <summary>
    ///     This is the Review model, which represents a review by a user in the LMS
    /// </summary>

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [Required]
        [Comment("The rating of the review")]
        public int Rating { get; set; }

        [MaxLength(1000)]
        [Comment("The comment of the review")]
        public string? Comment { get; set; }

        [Comment("When was the review created")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
