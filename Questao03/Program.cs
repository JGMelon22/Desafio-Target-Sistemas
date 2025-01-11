using System.Text.Json;

public class FaturamentoDiario
{
    public int dia { get; set; }
    public double valor { get; set; }
}

public class Program
{
    public static void Main()
    {
        string jsonString = File.ReadAllText("dados.json");

        var faturamento = JsonSerializer.Deserialize<List<FaturamentoDiario>>(jsonString);

        var diasComFaturamento = faturamento!.Where(f => f.valor > 0).ToList();

        double menorFaturamento = diasComFaturamento.Min(f => f.valor);
        var diaMenorFaturamento = diasComFaturamento.First(f => f.valor == menorFaturamento).dia;

        double maiorFaturamento = diasComFaturamento.Max(f => f.valor);
        var diaMaiorFaturamento = diasComFaturamento.First(f => f.valor == maiorFaturamento).dia;

        double mediaMensal = diasComFaturamento.Average(f => f.valor);

        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.valor > mediaMensal);

        Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2} (Dia {diaMenorFaturamento})");
        Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2} (Dia {diaMaiorFaturamento})");
        Console.WriteLine($"Média mensal: R$ {mediaMensal:F2}");
        Console.WriteLine($"Número de dias acima da média: {diasAcimaDaMedia}");
    }
}
