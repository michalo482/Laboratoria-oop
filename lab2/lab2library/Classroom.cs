using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2library
{
    public class Classroom
    {
        private string? name;   
        public string? Name { get { return name; } set { name = value; } }
        private Person[]? persons;

        public Classroom(string name, Person[] persons)
        {
            Name = name;
            this.persons = persons;
        }
        private string RenderClassroom()
        {
            string result = "";
            foreach (var person in persons)
            {
                result += person.ToString() + "\n";
            }
            return result;
        }
        public override string ToString() => $"Classroom: {Name} \n" + RenderClassroom();
        
    }
}
