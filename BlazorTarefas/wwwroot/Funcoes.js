window.MostraAlerta = (message) => {
    alert(message);
}

function getTotalTarefas() {
    DotNet.invokeMethodAsync("BlazorTarefas", "ObterTotalTarefas").then(resultado => {
        alert("Total de tarefas: " + resultado);
    });
}

function getTotalTarefasInstancia(dotnet) {
    dotnet.invokeMethodAsync("ObterTotalTarefasInstancia").then(resultado => {
        alert("Total de tarefas: " + resultado);
    });
}