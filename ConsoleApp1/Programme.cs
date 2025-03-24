class Programme
{
    static void Main(string[] args)
    {
        int salaire = 30000;

        float mensuel = calculMensuel(salaire);
        Console.WriteLine(args[0] + " mensuel : " + mensuel);
    }

    static float calculMensuel(int salaire)
    {
        float mensuel = salaire / 12;
        return mensuel;
    }
}