/*A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
Salário	Percentual de Reajuste
0 - 400.00
400.01 - 800.00
800.01 - 1200.00
1200.01 - 2000.00
Acima de 2000.00
15%
12%
10%
7%
4%
Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, 
em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e o
percentual de reajuste ganho, conforme exemplo abaixo.
 * 
 */



using System.Globalization;

double salario = double.Parse(Console.ReadLine());
double reajuste;
if (salario <= 400)
{
    reajuste = salario * 0.15;

    Console.WriteLine("Novo salario: " + (salario + (salario * 0.15)).ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 15 %");
}
else if (salario <= 800)
{
    reajuste = salario * 0.12;
    Console.WriteLine("Novo salario: " + (salario + (salario * 0.12)).ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 10 %");
}
else if (salario <= 1200)
{
    reajuste = salario * 0.10;
    Console.WriteLine("Novo salario: " + (salario + (salario * 0.10)).ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 10 %");
}
else if (salario <= 2000)
{
    reajuste = (salario * 0.07);
    Console.WriteLine("Novo salario: " + (salario + (salario * 0.07)).ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 7 %");
}
else if (salario > 2000)
{
    reajuste = (salario * 0.04);
    Console.WriteLine("Novo salario: " + (salario + (salario * 0.04)).ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 4 %");
}
