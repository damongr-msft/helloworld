using HelloWorldLib;
using System;
using System.Threading.Tasks;

namespace HelloWorldCli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHelloWorldSpeaker speaker= new HelloWorldSpeaker(Console.Out);
            await speaker.SayHelloAsync();
        }
    }
}
