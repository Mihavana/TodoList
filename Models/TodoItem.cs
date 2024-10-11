using System.ComponentModel.DataAnnotations;
namespace TodoList.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }

        public string? Description {get; set;}
        public bool IsDone {  get; set; }

        public static bool tri { get; set; } = false;
    }
}
