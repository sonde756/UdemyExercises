/*
Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
mostrando 4 casas decimais após a vírgula, segundo a fórmula:
Distancia =
Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a 
segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

 */


using System;
using System.Globalization;


double X1, Y1, X2, Y2;


string[] v = Console.ReadLine().Split(' ');
X1 = double.Parse(v[0], CultureInfo.InvariantCulture);
Y1 = double.Parse(v[1], CultureInfo.InvariantCulture);


string[] v1 = Console.ReadLine().Split(' ');
X2 = double.Parse(v1[0], CultureInfo.InvariantCulture);
Y2 = double.Parse(v1[1], CultureInfo.InvariantCulture);


double p1 = Math.Sqrt(Math.Pow(X2 - X1, 2.0) + Math.Pow(Y2 - Y1, 2.0));


Console.WriteLine(p1.ToString("F4", CultureInfo.InvariantCulture));

