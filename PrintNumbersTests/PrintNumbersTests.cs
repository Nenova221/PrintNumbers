using System.IO;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Printing;

namespace PrintNumbersTests
{
    public class PrintNumbersTests
    {
        [Theory]
        [InlineData(3, "1\n2\n3\n")]
        [InlineData(2, "1\n2\n")]
        [InlineData(5, "1\n2\n3\n4\n5\n")]
        public void Test1PrintNumbersToN_WithInputNumbers_ShouldReturnCorrectNumbers(int n, string expected)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            PrintNumbers.PrintNumbersToN(n);
            var result = stringWriter.ToString();
            Assert.Equal(expected, result);
        }

    }
}