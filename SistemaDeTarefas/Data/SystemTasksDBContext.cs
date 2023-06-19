using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SystemTasksDBContext : DbContext
    {
        public SystemTasksDBContext(DbContextOptions<SystemTasksDBContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<TaskModel> Tarefas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
