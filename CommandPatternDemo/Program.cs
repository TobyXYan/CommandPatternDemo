using System;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var invoker = new Invoker(new LightOnCommand(light), new LightOffCommand(light), new LightUpCommand(light), new LightDownCommand(light));
            invoker.TurnOnLight();
            invoker.ReverseOnLight();
            invoker.TurnOffLight();
            invoker.ReverseOffLight();
            invoker.TurnUpLight();
            invoker.ReverseUpLight();
            invoker.TurnDownLight();
            invoker.ReverseDownLight();
            Console.ReadLine();
        }
    }
}
