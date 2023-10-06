// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//RECUPERER LE PREMIER NOMBRE
Console.WriteLine("Entrez un nombre entier entre 1 et 10.");
int premierNombre = Convert.ToInt32(Console.ReadLine());

//RECUPERER L'OPERATEUR CHOISI
Console.WriteLine("Selectionnez votre opérateur.");
string operateur = Console.ReadLine();

//RECUPERER LE DEUXIEME NOMBRE
Console.WriteLine("Entrez un nombre entier entre 1 et 10.");
int secondNombre = Convert.ToInt32(Console.ReadLine());


//CALCULER
if (operateur == "+")
{
    int addition = premierNombre + secondNombre;
    Console.WriteLine("Le résultat est " + addition + ".");
}
else if (operateur == "-")
{
    int soustraction = premierNombre - secondNombre;
    Console.WriteLine("Le résultat est " + soustraction + ".");
}
else if (operateur == "*")
{
    int multi = premierNombre * secondNombre;
    Console.WriteLine("Le résultat est " + multi + ".");
}
else if (operateur == "/")
{
    int divi = premierNombre / secondNombre;
    Console.WriteLine("Le résultat est " + divi + ".");
}
else
{
    Console.WriteLine("Le calcul est impossible.");
}


