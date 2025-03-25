class Programme
{
    public static void Main()
    {
        Console.WriteLine("1- Afficher ses informations");
        Console.WriteLine("2- Calculer ses intérêts composés");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input == 1)
        {
            Console.Clear();
            User user = new User(1, "Bob", "Bricoleur", 24, 30000, 15, 10);
            user.PrintUserInfo();
            Console.WriteLine("");
            user.PrintSalaireParMois();
        }
        else if (input == 2)
        {
            Console.Clear();
            Console.WriteLine("Montant investit ? ");
            int montantInvestit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A quel taux ? ");
            int taux = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sur combien d'années ? ");
            int annee= Convert.ToInt32(Console.ReadLine());

            PrintInteretCompose(montantInvestit, taux, annee);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Faire un choix dans ceux proposés.");
            Main();
        }
    }

    private static void PrintInteretCompose(int montantInvestit, int taux, int annee)
    {
        double tauxInvestissement = taux / 100.0;
        double montantActuel = montantInvestit;
        for (int i = 0; i < annee; i ++)
        {
            double gainAjoute = montantActuel * tauxInvestissement;
            double montantTotal = montantActuel + gainAjoute;
            Console.WriteLine("Annee " + i + " : " + montantTotal);
            montantActuel = montantTotal;
        }
    }
}