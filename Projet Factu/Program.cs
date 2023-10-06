//Voici comment récupérer les valeurs de toutes les factures
// Console.WriteLine("Entrez les valeurs de vos factures, puis tapez STOP quand vous avez fini.");
// List<int> allFactures = new List<int>();
// bool continueAsking = true;
// do
// {
//     bool isOk = false;
//     do
//     {
//         string reponseString = "";
//         try
//         {
//             //on récupére une facture
//             Console.WriteLine("Quel est la valeur TTC de votre facture ?");
//             reponseString = Console.ReadLine();
//             int reponse = Convert.ToInt32(reponseString);
//             allFactures.Add(reponse);
//             isOk = true;
//         }
//         catch (Exception ex)
//         {
//             continueAsking = !string.Equals(reponseString, "STOP", StringComparison.CurrentCultureIgnoreCase);
//             Console.WriteLine("Entrée incorrecte, veuillez rééssayer");
//             isOk = false;
//         }
//     }
//     while (!isOk);
// }
// while (continueAsking);


// Console.WriteLine("Tapez sur n'importe quelle touche pour quitter l'application.");
// Console.ReadLine();

//RECUPERER LE NOMBRE DE FACTURES
Console.WriteLine("Combien de facture possedez-vous ?");
int nombreFacture = Convert.ToInt32(Console.ReadLine());

//DECLARER BRUT ANNUEL
int brutAnnuel = 0;
List<int> brutAnnuelList = new List<int>();

for (int i = 0; i < nombreFacture; i++)
{
    Console.WriteLine("Entrer le montant de votre facture" + i);
    int montant = Convert.ToInt32(Console.ReadLine());
    brutAnnuelList.Add(montant);
}

for (int i = 0; i < brutAnnuelList.Count; i++)
{
    brutAnnuel = brutAnnuelList[i] + brutAnnuel;
}

int brut = brutAnnuel / 12;
int net = brut * 85 / 100;
int netAnnuel = net / 12;
const int plafond = 36800;
int margeRestante = plafond - netAnnuel;

Console.WriteLine("Votre revenu brut est de  :" + brut);
Console.WriteLine("Votre revenu net est de" + net);
if (netAnnuel > plafond)
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("La marge de chiffre d'affaire est de " + margeRestante);
}
Console.ReadLine();