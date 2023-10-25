namespace usernamesiparola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string username = "Ezechiel";
            const string password = "UEO";
            string inputusername = null;
            while (inputusername != "Ezechiel")
            {
                Console.Write("Username: ");
                inputusername = Console.ReadLine();
                if (inputusername != username)
                {
                    Console.WriteLine("User nu a fost gasit");
                }
                else
                {
                    Console.Write("Parola: ");
                    string inputpassword = Console.ReadLine();
                    if (inputpassword != password)
                    {
                        Console.WriteLine("Parola este gresita");
                        inputusername = null; inputpassword = null;
                    }
                    else
                    {
                        Console.WriteLine("Bine ai venit, " + username + " !");
                    }
                }
            }

        }
    }
}