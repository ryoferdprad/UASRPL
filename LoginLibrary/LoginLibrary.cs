// LoginService.cs

namespace LoginLibrary
{
    public class LoginService
    {
        public bool Authenticate(string username, string password)
        {
            Console.WriteLine($"Provided username: {username}");
            Console.WriteLine($"Provided password: {password}");

            bool isAuthenticated = username == "ryoferdinand" && password == "kucing66";

            Console.WriteLine($"Authentication result: {isAuthenticated}");

            return isAuthenticated;
        }
    }
}
