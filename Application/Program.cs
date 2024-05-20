using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine(); // Read original password

            var encryptionService = new EncryptionLibrary.EncryptionService();
            var encryptedPassword = encryptionService.Encrypt(password);

            Console.WriteLine($"Encrypted Password: {encryptedPassword}");

            var loginService = new LoginLibrary.LoginService();
            bool isAuthenticated = loginService.Authenticate(username, password); // Pass original password

            if (isAuthenticated)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }
        }
    }
}
