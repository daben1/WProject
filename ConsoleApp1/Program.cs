using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyBaseClass : Object
    {
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
    }

    public class Test
    {

        public static void Main()
        {
            MyBaseClass myBase = new MyBaseClass();
            MyDerivedClass myDerived = new MyDerivedClass();
            object o = myDerived;
            MyBaseClass b = myDerived;
            var mybase1 = myBase.GetType();
            
            Console.WriteLine("mybase: Type is {0}", myBase.GetType());
            Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());
            Console.ReadKey();
        }
    }
}

