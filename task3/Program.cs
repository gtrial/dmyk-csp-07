using System;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            var myClass = new MyClass();
            MyClass.Method();

            var type = typeof(MyClass);
            var attributes = type.GetCustomAttributes(false);
            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine(attribute.Flag);
            }
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal class MyAttribute : System.Attribute
    {
        private readonly string attributeValue;

        public MyAttribute(string attributeValue)
        {
            this.attributeValue = attributeValue;
        }

        public int Flag { get; set; }
    }

    [MyAttribute("attribute value 0", Flag = 0)]
    internal class MyClass
    {
        [MyAttribute("attribute value 1", Flag = 1)]
        public static void Method()
        {
        }
    }
}