using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace TaskBoardApp.Models.Task
{
    public class TaskFormModel
    {
        public const int TaskMaxTitle = 70;
        public const int TaskMinTitle = 5;

        public const int TaskMaxDescription = 1000;
        public const int TaskMinDescription = 10;

        [Required]
        [StringLength(TaskMaxTitle, MinimumLength = TaskMinTitle, ErrorMessage = "Title should be at least {2} characters long.")]

        public string Title { get; set; } = null!;

        [Required]
        [StringLength(TaskMaxDescription, MinimumLength = TaskMinDescription, ErrorMessage = "Description should be at least {2} characters long.")]

        public string Description { get; set; } = null!;

        [Display(Name = "Board")]

        public int BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; } = null!;



    }
}
