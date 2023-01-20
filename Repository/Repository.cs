using Blazor_Tarefas.Entities;

namespace Blazor_Tarefas.Repository
{
    public class Repository : IRepository
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa {
                    Id = new Guid("f0dcda47-1f23-4538-92e0-a47dcdcc7850"),
                    Description = "Fazer o curso de Blazor",
                    Done= false,
                    CreatedAt= Convert.ToDateTime("2019-08-11"),

                },

                new Tarefa {
                    Id = new Guid("f0dcda47-1f23-4538-92e0-a48efeff7744"),
                    Description = "Estudar Blazor",
                    Done= false,
                    CreatedAt= Convert.ToDateTime("2019-09-05"),

                },


            };

        }
    }
}
