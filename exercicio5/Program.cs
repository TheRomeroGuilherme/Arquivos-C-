namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Insira um número inteiro positivo: ");
        int valor = int.Parse(Console.ReadLine());

        if (valor < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
            return;
        }

        ImprimirSequenciaFibonacci(valor);
        
        
    }
    static void ImprimirSequenciaFibonacci(int valor)
    {
        int a = 0, b = 1, c = 0;

        Console.Write("Sequência Fibonacci: ");
        if (valor >= 0) Console.Write(a + " ");  // Imprime 0
        if (valor >= 1) Console.Write(b + " ");  // Imprime 1

        while (true)
        {
            c = a + b;
            if (c > valor)
                break;

            Console.Write(c + " ");
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}
