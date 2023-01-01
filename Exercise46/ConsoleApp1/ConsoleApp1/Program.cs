

bool encontrado = false;

string[] nomes = new string[5];

for (int i = 0; i < 5; i++){
    Console.WriteLine("Escreva o nome");
    nomes[i] = Console.ReadLine();
}

Console.Clear();

Console.WriteLine("Escreva um nome para pesquisa");
string pesquisa = Console.ReadLine();


for (int i = 0; i < 5; i++) {

    if (nomes[i] == pesquisa) {
        Console.WriteLine("Achado");
        Console.WriteLine($"No array: {i}");
    }
    else if (nomes[i] != pesquisa )
      encontrado = true; 
}

if (encontrado != true) { Console.WriteLine("Não localizado"); }
    
   
//if (encontrado != true)
//    Console.WriteLine("Localizado");
//else
//    Console.WriteLine("Nada");

