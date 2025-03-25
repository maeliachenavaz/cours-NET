class Programme
{
    public static void Main()
    {
        User user = new User(1, "Bob", "Bricoleur", 24, 30000, 15, 10);
        user.PrintUserInfo();
        user.PrintSalaireParMois();
    }
}