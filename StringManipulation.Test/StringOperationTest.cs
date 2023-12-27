namespace StringManipulation.Test
{
    public class StringOperationTest
    {
        [Fact]
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

        [Fact]
        public void IsPalindrome_True()
        {
            //Arrage
            var stringOp = new StringOperations();

            //Act
            var result = stringOp.IsPalindrome("Ama");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrage
            var stringOp = new StringOperations();

            //Act
            var result = stringOp.IsPalindrome("hello");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            var stringOp = new StringOperations();

            var result = stringOp.RemoveWhitespace("Test remove spaces");

            Assert.DoesNotContain(" ", result);  
        }

        [Fact]
        public void QuantintyInWords()
        {
            var stringOp = new StringOperations();

            var result = stringOp.QuantintyInWords("cat", 5);

            Assert.StartsWith("cinco", result);
            Assert.Contains("cat", result);
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
    }
}
