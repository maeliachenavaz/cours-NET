class Programme
{
    public static void Main()
    {
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = InputToInt(Console.ReadLine());
        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = InputToInt(Console.ReadLine());

        if (salaireAnnuelBrut == 0 && tauxImposition == 0)
        {
            Console.WriteLine("Dommage pour vous..");
        } else
        {
            float salaireAnnuelNet = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

            Console.WriteLine("Salaire net mensuel : " + salaireAnnuelNet);
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
        float taxeImpostion = salaireMensuelBrut * (tauxImposition/100);

        float salaireAfterTaxe = salaireMensuelBrut - taxeImpostion;
        return salaireAfterTaxe;
    }

    private static float CalculSalaireMensuelBrut(int salaireAnnuelBrut)
    {
        float salaireMensuelBrut = salaireAnnuelBrut / 12;
        return salaireMensuelBrut;
    }
}