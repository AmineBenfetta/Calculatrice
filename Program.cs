using System;

class Program
{
    // Fonctions de la calculatrice
    static double addition(double a, double b)
    {
         return a + b;
    }

    static double soustraction(double a, double b)
    {
        return a - b;
    }

    static double multiplication(double a, double b)
    {
        return a * b;
    }

    static double division(double a, double b)
    {
            return a / b;
    }

    static double puissance(double a, double b)
    {
        return Math.Pow(a, b);
    }

    static void Main(string[] args)
    {
        double a = 0;
        while (true)
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
        double b = 0;
            // condition pour enchainer les opérations
            if (a > 0)
            {
            Console.WriteLine("Entrez le second nombre : ");
                 while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Erreur veuillez entrez un nombre!");
                    }
            } else if (a == 0)
            {
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
            }
                
        
            Console.Clear();
        Console.Write($"Résultat : ");

        // choix fonctionnels via un switch
            
            switch (options)
                {
                 case "1":
                    Console.WriteLine($"{a} + {b} = " + addition(a, b));
                   a = addition(a, b);
                    break;
                 case "2":
                    Console.WriteLine($"{a} - {b} = " + soustraction(a, b));
                    a = soustraction(a, b);
                    break;
                 case "3":
                    Console.WriteLine($"{a} x {b} = " + multiplication(a, b));
                    a = multiplication(a, b);
                    break;
                 case "4":
                    // Condition qui empèche le crash lors d'une division par 0.
                    if (b == 0)
                    {
                        Console.WriteLine("Impossible de diviser par 0!");
        }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = " + division(a, b));
                    }
                    a = division(a, b);
                    break;
                 case "5":
                    Console.WriteLine($"{a} puissance {b} = " + puissance(a, b));
                    a = puissance(a, b);
                    break;
                 default: 
                    Console.WriteLine("Options invalide!");
                    break;
                }
            if (a > 0)
            {
                continue;
            }

        }

    }
}
