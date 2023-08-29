using HR.Services;

namespace HR.API.Test1
{
    public class AccountNumberValidationTests
    {
        private readonly AccountNumberValidationService validationSvc;
        public AccountNumberValidationTests() => validationSvc = new AccountNumberValidationService();

        [Fact]
        public void IsValid_ValidAccountNumberReturnsTrue()
        {
            Assert.True(validationSvc.IsValid("123-1234567890-98"));

        }

        [Theory]
        [InlineData("1234-1234567890-98")]
        [InlineData("1-1234567890-98")]

        public void IsValid_FirstPartIsWrong_ReturnsFalse(string accountNumber)
        {
            Assert.False(validationSvc.IsValid(accountNumber));

        }


    }
}