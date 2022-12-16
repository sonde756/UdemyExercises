//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular
//com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais.
//Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno,
//ambos com duas casas decimais, conforme exemplo.

using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {

        double precoTerro = 200.00; 

        Console.WriteLine("Largura do terreno?");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Comprimento do terreno");
        double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Area total do terreno {(largura * comprimento).ToString("F2", CultureInfo.InvariantCulture)}");

        double area = largura * comprimento;

        Console.WriteLine($"Preço por M²:R$200. Valor total do terreno: {(area * precoTerro).ToString("F2", CultureInfo.InvariantCulture)}");



    }
}
