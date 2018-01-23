using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace GenerateCSBindings
{
    class BindingsGenerator : ILibrary
    {
        public void Postprocess(Driver driver, ASTContext ctx)
        {

        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {

        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            var module = options.AddModule("ecclib");
            module.IncludeDirs.Add(@"C:\Users\Wesley\dev\ecc-lib\ecc-lib");
            module.Headers.Add("ecclib.h");
            module.LibraryDirs.Add(@"C:\Users\Wesley\dev\ecc-lib\x64\Release");
            module.Libraries.Add("ecclib.lib");
        }

        public void SetupPasses(Driver driver)
        {

        }
    }
}
