Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
int numero = Convert.ToInt32(Console.ReadLine());

if (PertenceSequenciaFibonacci(numero))
{
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci!");
}
else
{
    Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci!");
}

bool PertenceSequenciaFibonacci(int numero)
{
    if (numero == 0 || numero == 1)
        return true;

    int anterior = 0;
    int atual = 1;

    while (atual <= numero)
    {
        if (atual == numero)
            return true;

        int proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
    }

    return false;
}
