namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCOUNT MANAGEMENT");

            string username = "usernamemo";
            string password = "urpassword11";

            Console.Write("Enter username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == username && passwordInput == password) {
                Console.WriteLine("Login Sucessful.");
            }
            else {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
    }
}
