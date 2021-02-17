using Models;
using System;
using System.Reflection;

namespace GarbageCollectorHomeWorkEighteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleMethods = new ConsoleMethods();
            consoleMethods.Text();

            Console.WriteLine();

            var testClass = new TestClass();
            testClass.Text();
        }
    }
}
