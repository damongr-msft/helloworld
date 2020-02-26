using System;
using System.IO;
using System.Threading.Tasks;

namespace HelloWorldLib
{
    public class HelloWorldSpeaker : IHelloWorldSpeaker
    {
        private TextWriter output;
        public HelloWorldSpeaker(TextWriter output)
        {
            this.output = output ?? throw new ArgumentNullException(nameof(output));
        }

        public Task SayHelloAsync()
        {
            return output.WriteLineAsync("Hello, World!");
        }
    }
}
