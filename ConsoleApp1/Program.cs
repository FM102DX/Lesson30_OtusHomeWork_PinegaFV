using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            A a1 = new B();
            B b = new B();
            C c = new C();

            a.ShowMe();
            a1.ShowMe();
            b.ShowMe();
            c.ShowMe();

            Console.ReadLine();

            //Console.WriteLine();
        }


        public class A
        {
            public void ShowMe()
            {
                Console.WriteLine("This is A");
            }
        }
        public class B:A
        {
            public new void ShowMe()
            {
                Console.WriteLine("This is B");
            }
        }

        public class C : B
        {
            public new void ShowMe()
            {
                Console.WriteLine("This is C");
            }
        }

    }
}
