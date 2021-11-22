using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass1
    {
        public int donatorInt;
    }

    class MyClass2
    {
        public void GetRefOut(ref int recipientInt) {
            Console.WriteLine("Value: " + recipientInt);
            Console.WriteLine("adsfasdf das asdfdasfdasf");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 mclass = new MyClass1();
            mclass.donatorInt = 10;
            mclass.donatorInt = 100;
        }
    }
}
