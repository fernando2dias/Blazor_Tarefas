using Blazor_Tarefas.Entities;

namespace Blazor_Tarefas.Repository
{
    public interface IRepository
    {
        List<Tarefa> ObterTarefas();
    }
}
