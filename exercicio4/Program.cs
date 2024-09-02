namespace exercicio4;

class Program
{
    static void Main(string[] args)
    {
        /*
        Desenvolver um algoritmo para ler o valor inteiro da idade de uma
        pessoa e imprimir uma das mensagens: se idade <= 13: Criança, se 
        idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se 
        idade > 60: Idoso.
        */
        int idade = 0;
        /*primeiro passo*/
        Console.WriteLine("Coloque a sua idade: ");
        idade = int.Parse(Console.ReadLine());
        /*segundo passo*/

        if (idade <= 13)
        {
            Console.WriteLine("Você é uma criança");
        }
        else if (idade > 13 && idade <= 18)
        {
            Console.WriteLine("Você é um Adolecente");
        }
        else if (idade > 18 && idade <= 60)
        {
            Console.WriteLine("Você é um(a) Adulto(a)");
        }
        else
        {
            Console.WriteLine("Você é um(a) idoso(a)");
        }

    }
}
