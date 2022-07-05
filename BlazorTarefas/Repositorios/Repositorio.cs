using BlazorTarefas.Entidades;

namespace BlazorTarefas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa()
                {
                    ID = new Guid("4ea73241-09be-487c-b9d4-8eb39106015b"),
                    Descricao = "Fazer o curso de Blazor",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2019-08-11")
                },

                new Tarefa()
                {
                    ID = new Guid("796745c4-92a4-4713-8559-573fb6e84fff"),
                    Descricao = "Estudar Blazor",
                    Concluida = true,
                    DataCriacao = DateTime.Parse("2019-09-05")
                }
            };
        }
    }
}
