using System.Runtime.CompilerServices;

class User
{
    private int id;
    private string firstName;
    private string lastName;
    private int age;
    private int salaireAnnuelBrut;
    private int tauxImposition;
    private int primeNoel;

    public User(int id, string firstName, string lastName, int age, int salaireAnnuelBrut, 
        int tauxImposition, int primeNoel)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salaireAnnuelBrut = salaireAnnuelBrut;
        this.tauxImposition = tauxImposition;
        this.primeNoel = primeNoel;
    }

    public int GetId() 
    { 
        return this.id; 
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public string GetFirstName() 
    { 
        return this.firstName; 
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string GetLastName() 
    { 
        return this.lastName; 
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public int GetAge() 
    { 
        return this.age; 
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetSalaireAnnuelBrut()
    {
        return this.salaireAnnuelBrut;
    }

    public void SetSalaireAnnuelBrut(int salaireAnnuelBrut)
    {
        this.salaireAnnuelBrut = salaireAnnuelBrut;
    }

    public int GetTauxImposition()
    {
        return this.tauxImposition;
    }

    public void SetTauxImposition(int tauxImposition)
    {
        this.tauxImposition= tauxImposition;
    }

    public int GetPrimeNoel()
    {
        return this.primeNoel;
    }

    public void SetPrimeNoel(int primeNoel)
    {
        this.primeNoel = primeNoel;
    }

    public double GetSalaireMensuelNet()
    {
        if (this.salaireAnnuelBrut == 0 || this.tauxImposition == 0)
        {
            return 0;
        }
        else
        {
            double salaireMensuelNet = CalculSalaireMensuelNet();

            return salaireMensuelNet;
        }
    }

    public void PrintSalaireParMois()
    {
        double salaireMensuelNet = this.CalculSalaireMensuelNet();

        if (this.salaireAnnuelBrut == 0 ||this. tauxImposition == 0)
        {
            Console.WriteLine("Dommage pour vous..");
        } else
        {
            Console.WriteLine("Salaire mensuel net par mois : ");
            foreach (Mois mois in Enum.GetValues(typeof(Mois)))
            {
                if (mois != Mois.Août && mois != Mois.Décembre)
                {
                    Console.WriteLine(mois + " " + salaireMensuelNet);
                }
                else if (mois == Mois.Décembre)
                {
                    double tauxPrime = this.primeNoel / 100.0;
                    double prime = salaireAnnuelBrut * tauxPrime;
                    double salaireAvecPrime = salaireMensuelNet + prime;
                    Console.WriteLine(mois + " " + salaireAvecPrime);
                }
            }
        }
    }

    public void PrintUserInfo()
    {
        Console.WriteLine("Id : " + this.id);
        Console.WriteLine("First name : " + this.firstName);
        Console.WriteLine("Last name : " + this.lastName);
        Console.WriteLine("Age : " + this.age);
        Console.WriteLine("Monthly salary: " + this.GetSalaireMensuelNet());
        if (this.salaireAnnuelBrut > 50000)
        {
            Console.WriteLine("Vous devriez faire un don pour réduire vos impôts.");
        }
        else if (this.salaireAnnuelBrut >= 30000 && this.salaireAnnuelBrut <= 40000)
        {
            Console.WriteLine("Viens au CESI pour un bac +5 en dév !");
        }
        else if (this.CalculSalaireMensuelBrut() < 1500)
        {
            Console.WriteLine("C'est normal pour un alternant c:");
        }
    }

    private double CalculSalaireMensuelNet()
    {
        double salaireMensuelBrut = this.CalculSalaireMensuelBrut();
        double taxeImpostion = this.CalculTaxeImposition(salaireMensuelBrut);

        double salaireAfterTaxe = salaireMensuelBrut - taxeImpostion;

        return salaireAfterTaxe;
    }

    private double CalculTaxeImposition(double salaireMensuelBrut)
    {
        double taxeImpostion = salaireMensuelBrut * (this.tauxImposition / 100);

        return taxeImpostion;
    }

    private double CalculSalaireMensuelBrut()
    {
        double salaireMensuelBrut = this.salaireAnnuelBrut / 12;

        return salaireMensuelBrut;
    }

    private int InputToInt(String input)
    {
        try
        {
            int inputToInt = Convert.ToInt32(input);

            return inputToInt;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Erreur : veuillez entrez un int.");
            int inputToInt = InputToInt(Console.ReadLine());
            return inputToInt;
        }
    }
}
