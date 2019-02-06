using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    static class FirstClass {
        static public int[] CreateArray(int size) {
            if (size > 0)
                return new int[size];
            return null;
        }
    }
}

namespace ConsoleApp2
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] a = MyArray.FirstClass.CreateArray(4);
            foreach (int i in a)
                Console.WriteLine(i);
            Console.Read();
        }
    }
}
