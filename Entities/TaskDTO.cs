namespace dotnet_practice.Entities
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; } = null;
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime DeleteAt { get; set; } = DateTime.Now;
    }
}