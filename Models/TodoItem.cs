﻿namespace TodoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description {get; set;}
        public bool IsDone {  get; set; }

        public static bool tri { get; set; } = false;
    }
}
