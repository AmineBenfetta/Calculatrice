using System;

class Program
{
    // Fonctions de la calculatrice
    static void addition(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    static void soustraction(double a, double b)
    {
        Console.WriteLine(a - b);
    }

    static void multiplication(double a, double b)
    {
        Console.WriteLine(a * b);
    }

    static void division(double a, double b)
    {
        // Condition qui empèche le crash lors d'une division par 0.
        if (b == 0)
        {
            Console.WriteLine("Impossible de diviser par 0!");
        } else
        {
            Console.WriteLine(a / b);
        }
    }

    static void puissance(double a, double b)
    {
        Console.WriteLine(Math.Pow(a, b));
    }

    static void Main(string[] args)
    {
        while(true)
        {


       // Menu avec choix de la calculatrice
        Console.WriteLine("-------- Calculatrice ---------");
        Console.WriteLine("1. Addition ");
        Console.WriteLine("2. Soustraction ");
        Console.WriteLine("3. Multiplication ");
        Console.WriteLine("4. Division ");
        Console.WriteLine("5. Puissance ");
        Console.WriteLine("0. Quitter ");
        Console.Write("Choisissez une options : ");
            string options = Console.ReadLine();
            if (options == "0")
            {
                return;
            }
            else if (options != "1" && options != "2" && options != "3" && options != "4" && options != "5")
            {
                Console.Clear();
                Console.WriteLine("Erreur! Veuillez choisir une option valide.");
                continue;
            }

        // Affichage après le choix de l'utilisateur
        double a;
        double b;
        Console.WriteLine("Entrez le premier nombre : ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Erreur veuillez entrez un nombre!");
            }
        Console.WriteLine("Entrez le second nombre : ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Erreur veuillez entrez un nombre!");
            }
            Console.Clear();
        Console.Write($"Résultat : ");

        // choix fonctionnels via un switch
        switch (options)
        {
            case "1":
                addition(a, b);
                break;
            case "2":
                soustraction(a, b);
                break;
            case "3":
                multiplication(a, b);
                break;
            case "4":
                division(a, b); 
                break;
            case "5":
                puissance(a, b);
                break;
            case "6":
                Console.WriteLine("Options invalide!");
                break;
            default: 
                Console.WriteLine("Options invalide!");
                break;
        }
        Console.WriteLine("Appuyez sur une touche pour retourner au menu.");
        Console.ReadKey();
            Console.Clear();

        }

    }
}
