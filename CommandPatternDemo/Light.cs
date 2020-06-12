using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    internal class Light
    {
        internal void DoLightOn()
        {
            Console.WriteLine("Light On"+Environment.NewLine);
        }

        internal void DoLightOff()
        {
            Console.WriteLine("Light Off" + Environment.NewLine);
        }

        internal void DoLightUp()
        {
            Console.WriteLine("Light Up" + Environment.NewLine);
        }

        internal void DoLightDown()
        {
            Console.WriteLine("Light Down" + Environment.NewLine);
        }
    }
}
