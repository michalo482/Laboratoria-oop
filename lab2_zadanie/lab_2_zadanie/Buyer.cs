using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    public class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {

        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoverProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override void Print()
        {
            Console.Write("        Buyer: ");
            base.Print();
            if (tasks.Count > 0)
            {
                Console.WriteLine("                --Products: --");
                foreach (var product in tasks)
                {
                    Console.Write("                ");
                    product.Print();
                }
            }
        }
    }
}
