using System;
using Xunit;
using System.IO;
using Devops.ConsoleApp;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Devops.UnitTest
{
    public class ConsoleUnitTest
    {
        [Fact]
        public void TestHelloWorldOutput()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main(new string[] { });

            Assert.Equal("Hello World\n", output.ToString());
        }
    }
}