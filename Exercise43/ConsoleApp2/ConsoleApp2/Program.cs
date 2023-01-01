/*
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:


Perimetro = XX.X


Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem


Area = XX.X

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal. 
 */
using System.Globalization;

string[] v = Console.ReadLine().Split(' ');
double A = double.Parse(v[0], CultureInfo.InvariantCulture);  
double B = double.Parse(v[1], CultureInfo.InvariantCulture);
double C = double.Parse(v[2], CultureInfo.InvariantCulture);



if(A < B + C && B < A + C && C < A + B)
{
    double peri = A + B + C; 
    Console.WriteLine("Perimetro = "+ peri.ToString("F2", CultureInfo.InvariantCulture));
}
else
{
    double area= (A +B)* C / 2;
    Console.WriteLine("Area = "+ area.ToString("F2", CultureInfo.InvariantCulture));
}