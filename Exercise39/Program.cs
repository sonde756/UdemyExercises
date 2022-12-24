using System.Globalization;

int i;
double soma, resumo, idade;
idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

soma = 0.0;
i = 0;

if (idade > 0)
{

    while (idade >= 0)
    {
        soma = soma + idade;
        i++;
        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    }
    resumo = soma / i;
    Console.WriteLine(resumo.ToString("F2", CultureInfo.InvariantCulture));
}
else
{
    Console.WriteLine("Impossivel calcular");
}

    