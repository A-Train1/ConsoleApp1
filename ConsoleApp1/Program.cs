using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<string> substrings = new List<string>(str.Split(' '));
            foreach(string s in substrings)
            {
                Console.WriteLine(s);
            }
            
            System.Threading.Thread.Sleep(2000);
        }
    }
}
