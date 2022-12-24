/*
Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada
X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

Entrada
A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y.
A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

Saída
Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente, 
caso contrário imprima a mensagem “Decrescente”.
 */
using System;
using System.Globalization;
namespace uri
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;
            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            while (x!=y)
            {

                if(x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);



            }
              

        }
    }
}