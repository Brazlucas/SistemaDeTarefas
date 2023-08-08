namespace SistemaDeTarefas.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        //public virtual ICollection<TaskModel> Tasks { get; set; } = new List<TaskModel>();
    }
}
