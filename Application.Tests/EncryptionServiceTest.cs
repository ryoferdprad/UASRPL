using Xunit;
using EncryptionLibrary;

namespace Application.Tests
{
    public class EncryptionServiceTest
    {
        [Fact]
        public void Encrypt_ValidInput_ReturnsEncryptedText()
        {
            // Arrange
            var encryptionService = new EncryptionService();
            string plainText = "Hello, World!";

            // Act
            string encryptedText = encryptionService.Encrypt(plainText);

            // Assert
            Assert.NotNull(encryptedText);
            Assert.NotEqual(plainText, encryptedText);
        }
    }
}
