/*
https://resources.beecrowd.com.br/gallery/images/problems/UOJ_1038_pt.png
 * Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

 * 
 */







using System.Globalization;


string[] v = Console.ReadLine().Split(' ');
int codigo = int.Parse(v[0]);
int quantidade = int.Parse(v[1]);


double total;

if(codigo == 1)
{
    total = quantidade * 4.0;
}
else if(codigo == 2)
{
    total = quantidade * 4.50;
}   
else if (codigo == 3)
{
    total = quantidade * 5.0;

}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else{
    total = quantidade * 1.50;
}

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
