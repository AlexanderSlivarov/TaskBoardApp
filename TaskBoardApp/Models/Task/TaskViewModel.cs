﻿namespace TaskBoardApp.Models.Task
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; init; } = null!;
        public string Description { get; init; } = null!;
        public string Owner { get; init; } = null!;
    }
}