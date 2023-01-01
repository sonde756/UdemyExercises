

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

string tudo = a +" "+ b +" "+ c;


switch(tudo) 
{
    case "vertebrado mamifero onivoro": Console.WriteLine("homem"); break;
    case "vertebrado mamifero herbivoro": Console.WriteLine("vaca"); break;
    case "vertebrado ave carnivoro": Console.WriteLine("aguia"); break;
    case "vertebrado ave onivoro": Console.WriteLine("pomba"); break;
    case "invertebrado anelideo onivoro": Console.WriteLine("minhoca"); break;
    case "invertebrado anelideo hematofago": Console.WriteLine("sanguessuga"); break;
    case "invertebrado inseto hematofago": Console.WriteLine("pulga"); break;
    case "invertebrado inseto herbivoro": Console.WriteLine("lagarta"); break;
        

    default :  break;
}