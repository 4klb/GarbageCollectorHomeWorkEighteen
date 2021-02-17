using Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Models
{
    public class TestClass : IPrinter
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public void Text()
        {
            Type type = typeof(TestClass);

            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine($"{property.PropertyType} {property.Name} ");
            }
        }
    }
}
