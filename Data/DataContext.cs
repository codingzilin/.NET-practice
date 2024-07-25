using Microsoft.EntityFrameworkCore;
using dotnet_practice.Entities;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TaskDTO> Tasks { get; set; }
    }