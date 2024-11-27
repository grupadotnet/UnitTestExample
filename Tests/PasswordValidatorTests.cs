using TestedLogic;

namespace Tests
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void Validate_NullPassword_ReturnsError()
        {
            // Arrange
            string? password = null;

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Password cannot be null.", result);
        }

        [Fact]
        public void Validate_ShortPassword_ReturnsError()
        {
            // Arrange
            string password = "Short1!";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Password must contain at least 8 characters.", result);
        }

        [Fact]
        public void Validate_NoUppercase_ReturnsError()
        {
            // Arrange
            string password = "lowercase1!";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Pasword must contain at least one uppercase character.", result);
        }

        [Fact]
        public void Validate_NoLowercase_ReturnsError()
        {
            // Arrange
            string password = "UPPERCASE1!";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Pasword must contain at least one lowercase character.", result);
        }

        [Fact]
        public void Validate_NoDigit_ReturnsError()
        {
            // Arrange
            string password = "NoDigits!";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Pasword must contain at least one digit.", result);
        }

        [Fact]
        public void Validate_NoSpecialCharacter_ReturnsError()
        {
            // Arrange
            string password = "NoSpecial1";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Contains("Pasword must contain at least special character.", result);
        }

        [Fact]
        public void Validate_ValidPassword_ReturnsNoErrors()
        {
            // Arrange
            string password = "Valid1!@";

            // Act
            var result = PasswordValidator.Validate(password);

            // Assert
            Assert.Empty(result);
        }
    }
}

