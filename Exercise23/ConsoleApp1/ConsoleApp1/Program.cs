int N, nota, resto,q;

N = int.Parse(Console.ReadLine());

Console.WriteLine(N);


resto = N;

nota = 100;
q = resto / nota;
resto %= nota;

Console.WriteLine(q + " nota(s) de R$ "+nota+",00");
nota = 50;
q = resto / nota;
resto %= nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00"); 
nota = 20;  
q = resto / nota;
resto = resto% nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00");
nota = 10;
q = resto / nota;
resto %= nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00");
nota = 5;
q = resto / nota;
resto %= nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00");
nota = 2;
q = resto / nota;
resto %= nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00");
nota = 1;
q = resto / nota;
resto %= nota;


Console.WriteLine(q + " nota(s) de R$ " + nota + ",00"); 