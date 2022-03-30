using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2library
{
    public class Person
    {
        protected string name = "";
        protected int age = 0;
        public string Name { get { return name; } }
        public int Age { get { return age; } } 

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return (Name == p.Name) && (Age == p.Age);
            }
        }

        public override string ToString() => $"{Name} ({Age} y.o.)";
        
    }
}
