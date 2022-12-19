int minutos, ad;
double conta;



Console.WriteLine("Minutos gastos");
minutos = int.Parse(Console.ReadLine());

conta = 50.0;
if (minutos >  100)
{
    conta +=  (minutos - 100) * 2.0;

    Console.WriteLine("Valor total a pagar R$ "+conta);

}
else
{
    Console.WriteLine("Valor total a pagar R$ 50");
}
