﻿namespace TaskBoardApp.Models
{
    public class HomeViewModel
    {
        public int AllTasksCount { get; init; }
        public List<HomeBoardModel> BoardsWithTasksCount { get; init; } = null!;
        public int UserTasksCount { get; set; }
    }
}
