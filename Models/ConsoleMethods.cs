using Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Models
{
    public class ConsoleMethods : IPrinter
    {
        public void Text()
        {
            Type type = typeof(Console);
            MethodInfo[] methodsArray = type.GetMethods();

            foreach (MethodInfo method in methodsArray)
            {
                Console.WriteLine($"{method.Name}");
            }
        }
    }
}
