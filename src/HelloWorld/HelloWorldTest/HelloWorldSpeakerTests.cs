using HelloWorldLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib.Tests
{
    [TestClass()]
    public class HelloWorldSpeakerTests
    {
    
        private static readonly string ExpectedHelloWorldMessage = "Hello, World!" + Environment.NewLine;

        [TestMethod()]
        public async Task SayHelloAsyncTest()
        {
            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            HelloWorldSpeaker speaker = new HelloWorldSpeaker(writer);

            await speaker.SayHelloAsync();

            string output = writer.ToString();

            Assert.AreEqual(ExpectedHelloWorldMessage, output);
        }
    }
}

