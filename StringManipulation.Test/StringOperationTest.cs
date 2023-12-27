using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Test
{
    public class StringOperationTest
    {
        [Fact(Skip = "This test is disabled in this moment")]
        public void ConcatenateStrings()
        {
            //Arrange
            var stringOperation = new StringOperations();

            //Act
            var result = stringOperation.ConcatenateStrings("Hello","Platzi");

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result); //Comprobar
        }

        [Theory]
        [InlineData("oro", true)]
        [InlineData("Hello", false)]
        public void IsPalindrome_Test(string word, bool expected)
        {
            //Arrage
            var stringOp = new StringOperations();

            //Act
            var result = stringOp.IsPalindrome(word);

            if(expected)
            {
                Assert.True(result);
            } else
            {
                Assert.False(result);
            }
        }

        [Theory]
        [InlineData("Phrase number one", "Phrasenumberone")]
        public void RemoveWhitespace(string phrase, string expected)
        {
            var stringOp = new StringOperations();

            var result = stringOp.RemoveWhitespace(phrase);

            //Assert.DoesNotContain(" ", result);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("car", 10, "diez cars")]
        [InlineData("country", 4, "cuatro countries")]
        [InlineData("dog", 1, "uno dog")]
        [InlineData("tree", 100, "cien trees")]
        public void QuantintyInWordsTest(string input, int quantity, string expected)
        {
            var stringOp = new StringOperations();

            var result = stringOp.QuantintyInWords(input, quantity);

            Assert.NotEmpty(result);
            Assert.Equal(expected, result);
            //Assert.StartsWith("cinco", result);
            //Assert.Contains("cat", result);
        }

        [Fact]
        public void GetStringLength()
        {
            var stringOp = new StringOperations();

            var result = stringOp.GetStringLength("Platzi");

            Assert.True(result > 0);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var stringOp = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => stringOp.GetStringLength(null));
           
        }

        [Fact]
        public void TruncateString()
        {
            var stringOp = new StringOperations();

            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => stringOp.TruncateString("hola", -1));
        }

        [Theory]
        [InlineData("V", 5)] // V = RomanNumber, 5 = result
        public void FromRomanToNumberTest(string romanNumber, int expected)
        {
            var stringOp = new StringOperations();

            var result = stringOp.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrencesTest()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();

            var stringOp = new StringOperations(mockLogger.Object);
            

            var result = stringOp.CountOccurrences("Hello platzi", 'l');

            Assert.Equal(result, 3);
        }

        [Fact]
        public void ReadFile()
        {
            var stringOp = new StringOperations();
            var mockFile = new Mock<IFileReaderConector>();
            mockFile.Setup(x => x.ReadString(It.IsAny<string>())).Returns("Reading file...");

            var result = stringOp.ReadFile(mockFile.Object, "archivo.txt");

            Assert.Equal("Reading file...", result);
        }
    }
}
