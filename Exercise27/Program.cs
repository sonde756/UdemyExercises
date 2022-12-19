int a, b, c;

string[] v = Console.ReadLine().Split(' ');
a = int.Parse(v[0]);
c = int.Parse(v[1]);
b = int.Parse(v[2]);


if (a <= b && a <= c)
{
    Console.WriteLine("MENOR = " + a);
}
else if (b <= a && b <= c)
{
    Console.WriteLine("MENOR = " + b);

}
else
{
    Console.WriteLine("MENOR = " + c);

}