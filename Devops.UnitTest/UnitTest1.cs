using Xunit;
using System.IO;
using Devops.ConsoleApp;

namespace Devops.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestConsoleInput()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(new string[] { });
                var result = sw.ToString().Trim();
                Assert.Equal("Hello World", result);
            }
        }
    }
}