Dictionary<string, decimal> faturamentoPorEstado = new Dictionary<string, decimal>
{
    { "SP", 67836.43m },
    { "RJ", 36678.66m },
    { "MG", 29229.88m },
    { "ES", 27165.48m },
    { "Outros", 19849.53m }
};

decimal faturamentoTotal = 0;
foreach (var faturamento in faturamentoPorEstado.Values)
{
    faturamentoTotal += faturamento;
}

foreach (var estado in faturamentoPorEstado)
{
    decimal percentual = (estado.Value / faturamentoTotal) * 100;
    Console.WriteLine($"Estado: {estado.Key}, Percentual de Representação: {percentual:F2}%");
}
