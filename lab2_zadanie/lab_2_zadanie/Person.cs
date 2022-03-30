namespace lab_2_zadanie
{
    public abstract class Person : IThing
    {
        private string? name;              
        private int? age;
        public int? Age { get => age; set => age = value; }
        public string? Name { get => name; set => name = value; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Name} ({Age} y.o.)");
        }
        


    }
}