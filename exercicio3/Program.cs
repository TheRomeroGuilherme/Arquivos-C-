namespace exercicio3;

class Program
{
    static void Main(string[] args)
    {
        //receber dois valores inteiros e informa qual deles e o maior
        int numero1 = 0;
        int numero2 = 0;

        /*primeiro passo*/
        Console.WriteLine("Vamos descobrir qual é o número maior!!!");

        Console.WriteLine("Coloque um número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Coloque um número: ");
        numero2 = int.Parse(Console.ReadLine());

        /*segundo passo*/

        if (numero1 > numero2)
        {
            Console.WriteLine($"O maior número é: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"O maior número é: {numero2}");
        }
        else
        {
            Console.WriteLine($"Ambos os número são iguais número1: {numero1} número2:{numero2}");
        }



    }
}
