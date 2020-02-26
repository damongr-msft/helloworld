using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib
{
    public interface IHelloWorldSpeaker
    {
        Task SayHelloAsync();
    }
}
