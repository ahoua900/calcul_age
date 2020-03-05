using System;

namespace formation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("entre votre nom ");
            var nom = Console.ReadLine();
            Console.WriteLine("entre votre jour de naissance ( le chiffre suffira) ");
            var der = Console.ReadLine();
            var day = Convert.ToInt32(der);
            Console.WriteLine("entre votre mois de naissance ( le chiffre suffira) ");
            var deree = Console.ReadLine();
            var month = Convert.ToInt32(deree);
            Console.WriteLine("entre votre année de naissance ( le chiffre suffira) ");
            var dere = Console.ReadLine();
            var year = Convert.ToInt32(dere);
            


            /*Costumer poule = new Costumer();
            poule.couleur = "jaune";

            Console.WriteLine(poule.couleur);*/

            File coq = new File();
            coq.FirstName = nom;
            coq.DateOfBirthday = day;
            coq.MonthOfBirthday = month;
            coq.YearOfBirthday = year;

            coq.Birthday();

            if (year >= 0 && year<=2020)
            {

               var age = 2020 - year;
                Console.WriteLine("vous etes né en "+ " "+ year + " "+ "et vous avez " + age+" "+" ans");
            }
            else
            {
                Console.WriteLine("entrer une bonne année de naissance");
            }
            if (month ==1)
            {
                Console.WriteLine("tu es de signe CAPRICORNE");
                Console.WriteLine("DESCRIPTION : Devenez votre propre patron. " +
                                "Choisissez vos horaires, générez un chiffre d'affaire compétitif et découvrez votre ville " +
                                "en effectuant des livraisons. Inscrivez-vous pour collaborer avec nous !");
            }
            else
            {
                Console.WriteLine("visite ce lien https://signezodiaque.com pour connaitre votre signe zodiaque");
            }
        }
    }
}
