class Programme
{
    public static void Main()
    {
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = Convert.ToInt32(Console.ReadLine());

        float salaireAnnuelNet = CalculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

        Console.WriteLine("Salaire net mensuel : " + salaireAnnuelNet);
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