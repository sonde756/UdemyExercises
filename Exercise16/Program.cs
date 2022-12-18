// Exercicio para fazer soma e calculo da idade média.

using System.Globalization;


double M;
Console.WriteLine("Digite seu nome + idade");
string[] v = Console.ReadLine().Split(' ');
string nome = v[0];
int idade = int.Parse(v[1]);

Console.WriteLine("Digite seu nome + idade");
string[] v1 = Console.ReadLine().Split(' ');
string nome1 = v1[0];
int idade1 = int.Parse(v1[1]);

M = (double)(idade + idade1)/2 ;

Console.WriteLine($"A idade média de {nome} e {nome1} é de {M.ToString("F1", CultureInfo.InvariantCulture)}");

Console.ReadLine();