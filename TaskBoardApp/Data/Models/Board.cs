using System.ComponentModel.DataAnnotations;

namespace TaskBoardApp.Data.Models
{
    public class Board
    {
        public const int BoardMaxName = 30;
        public int Id { get; init; }

        [Required]
        [MaxLength(BoardMaxName)]

        public string Name { get; set; } = null!;

        public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
    }
}
