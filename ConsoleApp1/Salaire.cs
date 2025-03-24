class Salaire
{
    public static void getSalaire()
    {
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = Salaire.InputToInt(Console.ReadLine());
        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = InputToInt(Console.ReadLine());

        if (salaireAnnuelBrut == 0 || tauxImposition == 0)
        {
            Console.WriteLine("Dommage pour vous..");
        }
        else
        {
            float salaireMensuelNet = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

            if (salaireAnnuelBrut > 50000)
            {
                Console.WriteLine("Vous devriez faire un don pour réduire vos impôts.");
            }
            else if (salaireAnnuelBrut >= 30000 && salaireAnnuelBrut <= 40000)
            {
                Console.WriteLine("Viens au CESI pour un bac +5 en dév !");
            }

            if (CalculSalaireMensuelBrut(salaireAnnuelBrut) < 1500)
            {
                Console.WriteLine("C'est normal pour un alternant c:");
            }

            Console.WriteLine("Salaire mensuel net : " + salaireMensuelNet);
        }
    }

    public static void getSalaireParMois()
    {
        foreach (String data in mois)
        {
            if (data != "Décembre")
            {
                Console.WriteLine(data + " 1500");
            } else
            {
                int salaireAnnuel = 1500 * 12;
                double tauxPrime = 0.10;
                double prime = salaireAnnuel * tauxPrime;
                double salaireAvecPrime = 1500 + prime;
                Console.WriteLine(data + " " + salaireAvecPrime);
            }
        }
    }

    private static IList<String> mois = new List<String> {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août",
        "Septembre", "Octobre", "Novembre", "Décembre" };
    private static int InputToInt(String input)
    {
        try
        {
            int inputToInt = Convert.ToInt32(input);

            return inputToInt;
        }
        catch (System.FormatException)
        {
            return 0;
        }
    }

    private static float CalculSalaireMensuelNet(int salaireAnnuelBrut, int tauxImposition)
    {
        float salaireMensuelBrut = CalculSalaireMensuelBrut(salaireAnnuelBrut);
        float taxeImpostion = CalculTaxeImposition(salaireMensuelBrut, tauxImposition);

        float salaireAfterTaxe = salaireMensuelBrut - taxeImpostion;

        return salaireAfterTaxe;
    }

    private static float CalculTaxeImposition(float salaireMensuelBrut, int tauxImposition)
    {
        float taxeImpostion = salaireMensuelBrut * (tauxImposition / 100);

        return taxeImpostion;
    }

    private static float CalculSalaireMensuelBrut(int salaireAnnuelBrut)
    {
        float salaireMensuelBrut = salaireAnnuelBrut / 12;

        return salaireMensuelBrut;
    }
}
