class Programme
{
    static void Main(string[] args)
    {
        Console.WriteLine("Salaire annuel brut : ");
        int salaireAnnuelBrut = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Taux d'imposition : ");
        int tauxImposition = Convert.ToInt32(Console.ReadLine());

        float salaireAnnuelNet = calculSalaireMensuelNet(salaireAnnuelBrut, tauxImposition);

        Console.WriteLine("Salaire net mensuel : " + salaireAnnuelNet);
    }

    static float calculSalaireMensuelNet(int salaireAnnuelBrut, int tauxImposition) 
    {
        float salaireMensuelBrut = calculSalaireMensuelBrut(salaireAnnuelBrut);
        float salaireAfterTaxe = salaireMensuelBrut - (salaireMensuelBrut * (tauxImposition / 100));
        return salaireAfterTaxe;
    }

    static float calculSalaireMensuelBrut(int salaireAnnuelBrut)
    {
        float salaireMensuelBrut = salaireAnnuelBrut / 12;
        return salaireMensuelBrut;
    }
}