using Xunit;

namespace StringManipulation.Test
{
    public class StringOperationTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var stringOperation = new StringOperations();

            var result = stringOperation.ConcatenateStrings("Hello","Platzi");

            Assert.Equal("Hello Platzi", result); //Comprobar
        }
    }
}
