
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    [Comment("A user of the system")]
    class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("The user's username")]
        public required string Username { get; set; }
        
        [Required]
        [MaxLength(255)]
        [Comment("The user's password")]
        public required string Password { get; set; }

        [Required]
        [MaxLength(320)]
        [RegularExpression(@"^[\w\-\.]+@([\w-]+\.)+[\w-]{2,4}$")]
        [Comment("The user's email address")]
        public required string Email { get; set; }

        [Required]
        public string Role { get; set; } = "User";

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    
        public DateTime LastLogin { get; set; }

        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
