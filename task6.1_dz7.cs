/* Task:
   Уявимо ситуацію - у вашого друга День народження.
   Використовуючи паттерн Сomposite реалізувати подарункову коробку-сюрприз,так звана коробка в коробці.В одній з них і буде подарунок!
*/



using System;
using System.Collections;
namespace CompositeExample
{
    class MainApp
    {
        static void Main()
        {
            // Create a box structure
            Component big_box = new BigBox("big box");
            big_box.Add(new SmallBox("small box1"));
            Component comp = new BigBox("small box2");
            comp.Add(new SmallBox("empty box"));
            comp.Add(new SmallBox("present"));
            big_box.Add(comp);
            big_box.Add(new SmallBox("small box3"));
            big_box.Add(new SmallBox("small box4"));
            // Add and remove a small box
            SmallBox leaf = new SmallBox("small box5");
            big_box.Add(leaf);
            big_box.Remove(leaf);
            // Recursively display box
            big_box.Display(1);
            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Component
    {
        protected string name;
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    // BigBox
    class BigBox : Component
    {
        private ArrayList children = new ArrayList();
        // Constructor
        public BigBox(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }

    // SmallBox
    class SmallBox : Component
    {
        // Constructor
        public SmallBox(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a box");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a box");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }
}
