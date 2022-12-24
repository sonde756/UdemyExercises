/*
 * 
 Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada
A entrada contém valores inteiros.

Saída
A saída deve conter uma das mensagens conforme descrito acima.
 */


string[] v = Console.ReadLine().Split(' ');
int a = int.Parse(v[0]);
int b = int.Parse(v[1]);


if(a % b == 0 || b % a == 0 ){
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}