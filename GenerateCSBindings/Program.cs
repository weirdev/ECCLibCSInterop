using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppSharp;

namespace GenerateCSBindings
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new BindingsGenerator();
            ConsoleDriver.Run(lib);
        }
    }
}
