using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TaskBoardApp.Data.Models
{
    public class Task
    {
        public const int TaskMaxTitle = 70;
        public const int TaskMinTitle = 5;

        public const int TaskMaxDescription = 1000;
        public const int TaskMinDescription = 10;
        public int Id { get; set; }

        [Required]
        [MaxLength(TaskMaxTitle)]

        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(TaskMaxDescription)]

        public string Description { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public int BoardId { get; set; }
        public Board? Board { get; set; }

        [Required]

        public string OwnerId { get; set; } = null!;

        public IdentityUser User { get; set; } = null!;

        public IdentityUser Owner { get; set; } = null!;
    }
}
