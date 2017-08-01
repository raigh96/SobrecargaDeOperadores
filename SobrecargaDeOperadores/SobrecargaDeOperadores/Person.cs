using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{
    class Person
    {
        private string Name;

        static void Main(string[] args)
        {
            var pedro = new Person() { Name = "Pedro" };
            var juan = new Person() { Name = "Pedro" };
        }

        public static Person operator == (Person a, Person b)
        {
            return new Person() { Name = a.Name + " " + b.Name + "son hermanos" };
        }

        public static Person operator != (Person a, Person b)
        {
            return new Person() { Name = a.Name + " " + b.Name + "no son hermanos" };
        }


    }
}
