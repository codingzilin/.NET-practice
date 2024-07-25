using dotnet_practice.Entities;

namespace dotnet_practice.Services
{
    public class TodoService
    {
        public List<TaskDTO> MockTodoItems { get; }

        public TodoService()
        {
            MockTodoItems = new List<TaskDTO>
            {
                new TaskDTO
                {
                    Id = 1,
                    Name = "Task 1",
                    Description = "Description 1",
                    DueDate = DateTime.Now,
                    Status = "In Progress",
                    Priority = "High",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    DeleteAt = DateTime.Now
                },
                new TaskDTO
                {
                    Id = 2,
                    Name = "Task 2",
                    Description = "Description 2",
                    DueDate = DateTime.Now,
                    Status = "In Progress",
                    Priority = "High",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    DeleteAt = DateTime.Now
                },
                new TaskDTO
                {
                    Id = 3,
                    Name = "Task 3",
                    Description = "Description 3",
                    DueDate = DateTime.Now,
                    Status = "In Progress",
                    Priority = "High",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    DeleteAt = DateTime.Now
                }
            };
        }

        public List<TaskDTO> GetTodoItems()
        {
            return MockTodoItems;
        }
    }
}