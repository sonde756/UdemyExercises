/*
 * 
 * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, 
 * mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes
com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem. 
 */


using System.Globalization;

double delta, r1, r2;

string[] v = Console.ReadLine().Split(' ');
double a = double.Parse(v[0], CultureInfo.InvariantCulture);
double b = double.Parse(v[1], CultureInfo.InvariantCulture);
double c = double.Parse(v[2], CultureInfo.InvariantCulture);

delta = Math.Pow(b, 2.0) - 4 * a * c;   


if(a == 0 || delta < 0.0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
    r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
    Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));

}






