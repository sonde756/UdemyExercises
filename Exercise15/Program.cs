


double b, a, area, perimetro, diagonal;

b= double.Parse(Console.ReadLine());    
a= double.Parse(Console.ReadLine());


area = b * a;
perimetro = 2 * a + 2 * b;

diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));


Console.WriteLine($"AREA = {a.ToString("F4")}");
Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4")}");
Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4")}");