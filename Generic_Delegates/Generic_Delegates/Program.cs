using System;
using System.Collections.Generic;

namespace Generic_Delegates
{
    class Program
    {
        //public delegate bool Filter(int n);//Normal delegate
       // public delegate bool Filter<in T>(T n);//Generic delegate that take generic T and return bool
        //public delegate T1 Filter<in T,out T1>(T n);//Generic delegate that take generic T and return generic T1
        static void Main(string[] args)
        {
            IEnumerable<int> list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print(list, l => l < 6);
            IEnumerable<double> list1 = new double[] { 1.1, 2.3, 3.5, 4.5, 5.6, 6.2, 7.3, 8.2, 9.1 };
            Print(list1, l => l < 6.2);
            Console.ReadKey();
        }
        static void Print<T>(IEnumerable<T> list,Predicate<T> filter)
        {
            foreach (var l in list)
            {
                if (filter(l))
                    Console.WriteLine(l);
            }
        }
    }
}
