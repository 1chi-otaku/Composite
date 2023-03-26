using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string name { get; set; }
        protected double price { get; set; }

        public Component(string name, double price)
        {
            this.name= name;
            this.price = price;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }


    class Composite:Component
    {
        public List<Component> components { get; set; }
        public Composite(string name, double price) : base(name, price) { 
            components = new List<Component>(); 
        }
        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Display(int depth)
        {
            string separator = new string('-', depth);
            Console.WriteLine(separator + " " +  name + " - " + price);
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Display(depth+1);
            }
        }
    }

    class Leaf : Component
    {
        public Leaf(string name, double price) : base(name, price) { }
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            string separator = new string('-', depth);
            Console.WriteLine(separator + " " + name + " - " + price);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
