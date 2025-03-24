class Programme
{
    public static void Main()
    {
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = InputToInt(Console.ReadLine());
        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = InputToInt(Console.ReadLine());

        if (salaireAnnuelBrut == 0 || tauxImposition == 0)
        {
            Console.WriteLine("Dommage pour vous..");
        } else
        {
            float salaireMensuelNet = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

            if (salaireAnnuelBrut > 50000)
            {
                Console.WriteLine("Vous devriez faire un don pour réduire vos impôts.");
            } else if (salaireAnnuelBrut >= 30000 && salaireAnnuelBrut <= 40000)
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

    private static int InputToInt(String input)
    {
        try
        {
            int inputToInt = Convert.ToInt32(input);

            return inputToInt;
        } catch (System.FormatException) {
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

    private static float CalculTaxeImposition (float salaireMensuelBrut ,int tauxImposition)
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