/*
 * 
Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

Entrada
A entrada contem três números inteiros.

Saída
Imprima a saída conforme foi especificado.
 * 
 */



using System;
using System.Collections.Generic;
using System.Collections;



string[] v = Console.ReadLine().Split(' ');
        int a = int.Parse(v[0]);
        int b = int.Parse(v[1]);
        int c = int.Parse(v[2]);

     
        List<int> lista = new List<int>();   
        lista.Add(a);
        lista.Add(b);
        lista.Add(c);
        lista.Sort();

foreach(int i in lista)
{
    Console.WriteLine(i);
}

Console.WriteLine("");

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
      