using BlazorTarefas.Entidades;

namespace BlazorTarefas.Repositorios
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
