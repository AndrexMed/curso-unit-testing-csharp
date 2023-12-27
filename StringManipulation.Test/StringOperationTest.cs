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
    }
}
