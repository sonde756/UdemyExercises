/*
Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, 
calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas 
são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a 
relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.

 */



using System.Globalization;

int moeda,nota, resto, q;
double N;
N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

resto = (int) (N*100.0 + 0.5);

Console.WriteLine("NOTAS:");

nota = 100;
q = resto / (nota*100);
resto %= (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");
nota = 50;
q = resto / (nota * 100);
resto %= (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");
nota = 20;
q = resto / (nota * 100);
resto = resto % (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");
nota = 10;
q = resto / (nota * 100);
resto %= (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");
nota =5;
q = resto / (nota * 100);
resto %= (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");

nota = 2;
q = resto / (nota * 100);
resto %= (nota * 100);

Console.WriteLine(q + " nota(s) de R$ " + nota + ".00");


Console.WriteLine("MOEDAS:");
// MOEDAS

moeda = 100;
q = resto / moeda;
resto %= moeda;

Console.WriteLine(q + " moeda(s) de R$ 1.00");

moeda = 50;
q = resto / moeda;
resto %= moeda;
Console.WriteLine(q + " moeda(s) de R$ 0.50");

moeda = 25;
q = resto / moeda;
resto %= moeda;
Console.WriteLine(q + " moeda(s) de R$ 0.25");

moeda = 10;
q = resto / moeda;
resto %= moeda;
Console.WriteLine(q + " moeda(s) de R$ 0.10");

moeda = 5;
q = resto / moeda;
resto %= moeda;
Console.WriteLine(q + " moeda(s) de R$ 0.05");

Console.WriteLine(resto + " moeda(s) de R$ 0.01");

