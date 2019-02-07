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

        static public void CreateArray(int size, out int[] array) {
            if (size > 0)
                array = new int[size];
            else
                array = null;
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
            MyArray.FirstClass.CreateArray(5, out int[] b);
            foreach (int i in a)
                Console.WriteLine(i);
            Console.WriteLine("next b");
            foreach (int i in b)
                Console.WriteLine(i);
            Console.Read();
        }
    }
}
