using Microsoft.EntityFrameworkCore;
using dotnet_practice.Entities;

namespace dotnet_practice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TaskDTO> Tasks { get; set; }
    }
}