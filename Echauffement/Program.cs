using System.Data;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        Console.WriteLine("Mihai, Uncharted 4");
        
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton prénom ? "); 
        string prenom = Console.ReadLine(); 
        
        Console.WriteLine("Quel âge as-tu ? "); 
        int age = Convert.ToInt32(Console.ReadLine());
        
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        
        if (age < 18)
        {
            Console.WriteLine("Tu es mineur");
        }
        else
        {
            Console.WriteLine("Tu es majeur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre entier)
        
        Console.WriteLine("Quel est ton budget");
        float budget = Convert.ToInt32(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prixca
        
        Console.Write("Hache de la mort qui tue ");
        Console.WriteLine("Prix : 100");
        
        Console.Write("couteau qui décoiffe ");
        Console.WriteLine("Prix : 30");
        
        Console.Write("Pistolet trop Swag ");
        Console.WriteLine("Prix : 10");
        
        Console.Write("Les poings archi puissants ");
        Console.WriteLine("Prix : 50");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Choisissez votre arme de 1 à 4 : ");
        int arme = Convert.ToInt32(Console.ReadLine());

        if (arme == 1)
        {
            Console.WriteLine("Votre arme est : Hache de la mort qui tue");
        }
        else if (arme == 2)
        {
            Console.WriteLine("Votre arme est : couteau qui décoiffe");
        }
        else if (arme == 3)
        {
            Console.WriteLine("Votre arme est : Pistolet trop Swag");
        }
        else if (arme == 4)
        {
            Console.WriteLine("Votre arme est : Les poings archi puissants");
        }

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

       if (arme == 1 && budget >= 100)
        {
            Console.WriteLine("Vous avez assez d'argent pour acheter cette arme.");
        }
        else if (arme == 2 && budget >= 30)
        {
            Console.WriteLine("Vous avez assez d'argent pour acheter cette arme.");
        }
        else if (arme == 3 && budget >= 10)
        {
            Console.WriteLine("Vous avez assez d'argent pour acheter cette arme.");
        }
        else if (arme == 4 && budget >= 50)
        {
            Console.WriteLine("Vous avez assez d'argent pour acheter cette arme.");
        }
        else
        {
            Console.WriteLine("Vous n'avez pas assez d'argent.");
        }
        
        
       
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent

        if (arme == 1 && budget >= 100 && age >= 18)
        {
            Console.WriteLine("Vous avez assez d'argent et l'âge pour acheter l'arme.");
            budget = budget - 100;
            Console.WriteLine("Achat effectué !");
        }
        else if (arme == 2 && budget >= 30 && age >= 18)
        {
            Console.WriteLine("Vous avez assez d'argent et l'âge pour acheter l'arme.");
            budget = budget - 30;
            Console.WriteLine("Achat effectué !");
        }
        else if (arme == 3 && budget >= 10 && age >= 18)
        {
            Console.WriteLine("Vous avez assez d'argent et l'âge pour acheter l'arme.");
            budget = budget - 10;
            Console.WriteLine("Achat effectué !");
        }
        else if (arme == 4 && budget >= 50 && age >= 18)
        {
            Console.WriteLine("Vous avez assez d'argent et l'âge pour acheter l'arme.");
            budget = budget - 50;
            Console.WriteLine("Achat effectué !");
        }
        else
        {
            Console.WriteLine("Vous n'avez pas assez d'argent ou l'age pour l'achat.");
        }

        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}