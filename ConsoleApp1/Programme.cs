class Programme
{
    static void Main(string[] args)
    {
        int salaire = Convert.ToInt32(args[0]);
        int taxe = Convert.ToInt32(args[1]);

        float salaireNet = calculSalaireMensuelNet(salaire, taxe);
        Console.WriteLine("Salaire annuel brut : " + salaire);
        Console.WriteLine("Taxe : " + taxe);
        Console.WriteLine("Salaire net mensuel : " + salaireNet);
    }

    static float calculSalaireMensuelNet(int salaire, int taxe) 
    {
        float salaireMensuel = calculSalaireMensuelBrut(salaire);
        float tauxImposition = taxe / 100;
        float salaireAfterTaxe = salaireMensuel - (salaireMensuel * tauxImposition);
        return salaireAfterTaxe;
    }

    static float calculSalaireMensuelBrut(int salaire)
    {
        float mensuel = salaire / 12;
        return mensuel;
    }
}