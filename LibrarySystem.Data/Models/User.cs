
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
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
        [Comment("The user's profile picture")]
        // The profile picture is required because every user must have one 
        // If the user doesn't have a profile picture, a default profile picture will be used
        public required string ProfilePicture { get; set; }

        public enum UserRoles
        {
            User,
            Admin
        }

        [Required]
        [Comment("The user's role")]
        // There are 2 roles: User and Admin
        public UserRoles Role { get; set; } = UserRoles.User;

        [Required]
        [Comment("When was the user created")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        [Comment("When did the user last log in")]
        public DateTime LastLogin { get; set; }

        [Comment("A collection of the books taken by the user")]
        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
