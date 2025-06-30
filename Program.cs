using System;

class Program
{
    // Fonctions de la calculatrice
    static void addition(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void soustraction(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    static void Main(string[] args)
    {
       // Menu avec choix de la calculatrice
        Console.WriteLine("-------- Calculatrice ---------");
        Console.WriteLine("1. Addition ");
        Console.WriteLine("2. Soustraction ");
        Console.WriteLine("3. Multiplication ");
        Console.WriteLine("4. Division ");
        Console.WriteLine("5. Puissance ");
        Console.WriteLine("6. Quitter ");
        Console.Write("Choisissez une options : ");
        int options = int.Parse(Console.ReadLine());

        // Affichage après le choix de l'utilisateur
        Console.WriteLine("Entrez le premier nombre : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Entrez le second nombre : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Résultat : ");

        // choix fonctionnels via un switch
        switch(options)
        {
            case 1:
                addition(a, b);
                break;
            case 2:
                soustraction(a, b);
                break;
            case 3:
                Console.WriteLine("Options invalide!");
                break;
            case 4:
                Console.WriteLine("Options invalide!");
                break;
            case 5:
                Console.WriteLine("Options invalide!");
                break;
            case 6:
                Console.WriteLine("Options invalide!");
                break;
            default: 
                Console.WriteLine("Options invalide!");
                break;
        }
        Console.WriteLine("Appuyez sur une touche pour quitter...");
        Console.ReadKey();

    }
}