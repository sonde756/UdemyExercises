/*
 *Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
 *código de uma peça 2, 
 *o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, 
respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de
deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto. 
 * 
 */




string[] v = Console.ReadLine().Split(' ');
int cod = int.Parse(v[0]);
int quant = int.Parse(v[1]);
double valor = double.Parse(v[2]);

double num1 = quant * valor;

string[] v1 = Console.ReadLine().Split(' ');
int cod1 = int.Parse(v1[0]);
int quant1 = int.Parse(v1[1]);
double valor1 = double.Parse(v1[2]);


double num2 = quant1 * valor1;

Console.WriteLine("VALOR A PAGAR: R$ " +(num1+num2).ToString("F2"));


