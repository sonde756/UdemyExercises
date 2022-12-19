/*
 * Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for 
 * maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos",
 * senão escrever "Valores nao aceitos".

Entrada
Quatro números inteiros A, B, C e D.

Saída
Mostre a respectiva mensagem após a validação dos valores.
  
 */
int a, b, c, d;

string[] v = Console.ReadLine().Split(' ');
a = int.Parse(v[0]);
b = int.Parse(v[1]);
c = int.Parse(v[2]);
d = int.Parse(v[3]);




if (b > c && d > a && c+d > a+b && a%2==0 && c > 0 && d > 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}