namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        //precisamos calcular um retângulo 
        //precisamos pegar largura e altura

        double area = 0.0;
        double altura = 0.0;
        double largura = 0.0;

        /*primeiro passo*/
        Console.WriteLine("Vamos calcular as áreas de um retângulo quadrado");

        Console.WriteLine("coloque a altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Coloque a largura: ");
        largura = double.Parse(Console.ReadLine());

        /*segundo passo*/

        area = altura * largura;
        /*terceiro passo*/

        Console.WriteLine($"Total da área do retângulo quadrado: {area:F2}");
    }
}
