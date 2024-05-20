using Xunit;
using LoginLibrary;

namespace Application.Tests
{
    public class LoginServiceTest
    {
        [Fact]
        public void Authenticate_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var loginService = new LoginService();
            string username = "ryoferdinand";
            string password = "kucing66";

            // Act
            bool isAuthenticated = loginService.Authenticate(username, password);

            // Assert
            Assert.True(isAuthenticated);
        }

        [Fact]
        public void Authenticate_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var loginService = new LoginService();
            string username = "invaliduser";
            string password = "invalidpassword";

            // Act
            bool isAuthenticated = loginService.Authenticate(username, password);

            // Assert
            Assert.False(isAuthenticated);
        }
    }
}
