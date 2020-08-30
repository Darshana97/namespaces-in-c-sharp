using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();
            Console.ReadLine();


        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello from class A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello from class B");
            }
        }
    }
}
