namespace Blazor_Tarefas.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}