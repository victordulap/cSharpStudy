using System;
using System.Collections.Generic;
using System.Linq;

namespace Lectia16_
{
    namespace ExpresiiFunc
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        //1
        //        Func<string, string> func1 = (x) => (x.Substring(0, x.Length / 2));
        //        Console.WriteLine(func1.Invoke("abcde"));

        //        //2
        //        Func<int, int> func2 = (x) => (Convert.ToInt32(Math.Pow(x, 3)));
        //        Console.WriteLine(func2.Invoke(2));

        //        //3
        //        Func<int, int> func3 = (x) =>
        //        {
        //            if (x % 2 == 0)
        //                return x / 2;
        //            else
        //                return x * 2;
        //        };
        //        Console.WriteLine(func3.Invoke(3));
        //    }
        //}
    }

    namespace ExpresiiFuncParametru
    {
        //class Program
        //{
        //    static void Main()
        //    {
        //        IEnumerable<string> strings = new List<string> { "one", "Two", "three", "four" };
        //        IEnumerable<string> result = strings.Select(x =>
        //        {
        //            if (x[0].ToString().ToLower() == "t")
        //                return x + x.ToUpper();
        //            else
        //                return x;
        //        });

        //        foreach (var element in result)
        //            Console.WriteLine(element);
        //    }
        //}
    }

    namespace SingletonPattern
    {
        //class MainApp
        //{

        //    static void Main()
        //    {
        //        // Constructor is protected -- cannot use new

        //        Singleton s1 = Singleton.Instance();
        //        Singleton s2 = Singleton.Instance();

        //        // Test for same instance

        //        if (s1 == s2)
        //        {
        //            Console.WriteLine("Objects are the same instance");
        //        }

        //        // Wait for user

        //        Console.ReadKey();
        //    }
        //}

        //class Singleton

        //{
        //    private static Singleton instance;

        //    public int X { get; set; }

        //    protected Singleton()
        //    {
        //    }

        //    public static Singleton Instance()
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Singleton();
        //        }

        //        return instance;
        //    }
        //}
    }

    namespace CompositePattern
    {
        class MainApp
        {
            static void Main()
            {
                // Create a tree structure

                Composite root = new Composite("root");
                root.Add(new Leaf("Leaf A"));
                root.Add(new Leaf("Leaf B"));

                Composite comp = new Composite("Composite X");
                comp.Add(new Leaf("Leaf XA"));
                comp.Add(new Leaf("Leaf XB"));

                root.Add(comp);
                root.Add(new Leaf("Leaf C"));

                // Add and remove a leaf

                Leaf leaf = new Leaf("Leaf D");
                root.Add(leaf);
                root.Remove(leaf);

                // Recursively display tree

                root.Display(1);

                // Wait for user

                Console.ReadKey();
            }
        }

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

        class Composite : Component

        {
            private List<Component> _children = new List<Component>();

            // Constructor

            public Composite(string name)
              : base(name)
            {
            }

            public override void Add(Component component)
            {
                _children.Add(component);
            }

            public override void Remove(Component component)
            {
                _children.Remove(component);
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);

                // Recursively display child nodes

                foreach (Component component in _children)
                {
                    component.Display(depth + 2);
                }
            }
        }

        class Leaf : Component

        {
            // Constructor

            public Leaf(string name)
              : base(name)
            {
            }

            public override void Add(Component c)
            {
                Console.WriteLine("Cannot add to a leaf");
            }

            public override void Remove(Component c)
            {
                Console.WriteLine("Cannot remove from a leaf");
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);
            }
        }
    }

}
