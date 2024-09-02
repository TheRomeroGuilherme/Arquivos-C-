namespace Exercicio2;

class Exercicio2
{
    static void Main(string[] args)
    {
        //criar um transformador de reais em dolar 
        //cliente digita um valor em reais
        //tem as contas para conversão 
        //mostrar os resultados de 

        //cotação 
        /*
        1. Dólar (1 dólar = 5,17 reais)
        2. Euro (1 euro = 6,14 reais)
        3. Peso argentino (1 peso argentino = 0,05 reais)
        */

        double reais=0;
        double valor_Dolar= 5.17;
        double Total_Dolar=0;
        double valor_Euro= 6.14;
        double Total_Euro=0;
        double valor_PesosArgentinos= 0.05;
        double Total_PesosArgentinos=0;
        
        /*Primeiro passo*/
        Console.WriteLine("Escreva um número para a cotação");
        reais= double.Parse(Console.ReadLine());

        /*Segundo passo*/
        Total_Dolar = reais / valor_Dolar;

        Total_Euro = reais/ valor_Euro;

        Total_PesosArgentinos =reais / valor_PesosArgentinos;

        /*Terceiro passo*/

        Console.WriteLine($"O valor total em Dólar: {Total_Dolar:F2}");
        Console.WriteLine($"O valor total em Euro: {Total_Euro:F2}");
        Console.WriteLine($"O valor total em Pesos Argentinos: {Total_PesosArgentinos:F2}");
    }
}
