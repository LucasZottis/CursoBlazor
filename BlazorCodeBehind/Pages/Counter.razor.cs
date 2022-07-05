using BlazorCodeBehind.Servicos;
using Microsoft.AspNetCore.Components;

namespace BlazorCodeBehind.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Inject] Servico1 servico { get; set; }
        protected void IncrementCount()
        {
            currentCount++;
            servico.Valor++;
        }
    }
}