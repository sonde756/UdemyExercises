/*
 * 
 * Escreva um programa que leia três valores com ponto flutuante 
de dupla precisão: A, B e C. Em seguida, calcule e mostre:

a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após 
o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados.
 Cada linha corresponde a uma das áreas descritas acima, 
sempre com mensagem correspondente e um espaço entre os
 dois pontos e o valor. O valor calculado deve ser apresentado 
com 3 dígitos após o ponto decimal.
 */


using System.Globalization;
double a, b, c;

string[] v = Console.ReadLine().Split(' ');
a = double.Parse(v[0], CultureInfo.InvariantCulture);
b = double.Parse(v[1], CultureInfo.InvariantCulture);
c = double.Parse(v[2], CultureInfo.InvariantCulture);

double triangulo = (a * c)/2.0;
double circulo = 3.14159 * c * c;
double trapezio = ((a + b)*c)/2;
double quadrado = b * b;
double retangulo = a * b;

Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: "+circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: "+trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: "+quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: "+retangulo.ToString("F3", CultureInfo.InvariantCulture));

