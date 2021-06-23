using System;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            MyClass.Method1();
            //MyClass.Method2();
        }
    }

    internal class MyClass
    {
        [Obsolete("", error:false)]
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        [Obsolete("", error: true)]
        public static void Method2()
        {
            Console.WriteLine("Method1");
        }
    }
}