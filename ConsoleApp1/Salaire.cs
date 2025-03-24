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
            double salaireMensuelNet = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

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
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = Salaire.InputToInt(Console.ReadLine());

        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = InputToInt(Console.ReadLine());

        Console.WriteLine("Montant prime de Noël : ");
        int primeNoel = InputToInt(Console.ReadLine());

        double salaireMensuel = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

        Console.WriteLine("Salaire mensuel net par mois : ");
        foreach (String data in mois)
        {
            if (data != "Août" && data != "Décembre")
            {
                Console.WriteLine(data + " " + salaireMensuel);
            } else if (data == "Décembre")
            {
                double tauxPrime = primeNoel / 100.0;
                double prime = salaireAnnuelBrut * tauxPrime;
                double salaireAvecPrime = salaireMensuel + prime;
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

    private static double CalculSalaireMensuelNet(int salaireAnnuelBrut, int tauxImposition)
    {
        double salaireMensuelBrut = CalculSalaireMensuelBrut(salaireAnnuelBrut);
        double taxeImpostion = CalculTaxeImposition(salaireMensuelBrut, tauxImposition);

        double salaireAfterTaxe = salaireMensuelBrut - taxeImpostion;

        return salaireAfterTaxe;
    }

    private static double CalculTaxeImposition(double salaireMensuelBrut, int tauxImposition)
    {
        double taxeImpostion = salaireMensuelBrut * (tauxImposition / 100);

        return taxeImpostion;
    }

    private static double CalculSalaireMensuelBrut(int salaireAnnuelBrut)
    {
        double salaireMensuelBrut = salaireAnnuelBrut / 12;

        return salaireMensuelBrut;
    }
}
