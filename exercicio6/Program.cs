namespace exercicio6;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        BubbleSort(vetor);

        Console.WriteLine("\nVetor ordenado:");
        ImprimirVetor(vetor);
    }

    static void BubbleSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    // Troca de elementos
                    int temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
