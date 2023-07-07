using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Methood
            //Print(1);
            //Print("Islam");
            //Print('I');
            //Print(new { fname = "Islam", Lname = "Mohammed" }); //Anonymous Object
            #endregion
            
            Console.ReadKey();
        }
        #region Old Way 
        //static void Print(int value)
        //{
        //    Console.WriteLine(value);
        //}
        //static void Print(string  value)
        //{
        //    Console.WriteLine(value);
        //}
        //static void Print(char value)
        //{
        //    Console.WriteLine(value);
        //}
        // I can Solve That By Using Object
        //static void Print(object value)
        //{
        //    Console.WriteLine(value);
        //}
        // but better use Generics
        #endregion
        #region Generic Methood
        //public static void Print<T>(T value)
        //{
        //    Console.WriteLine(typeof(T));
        //    Console.WriteLine(value);
        //}
        #endregion
    }
    public class any<T> //where T :class Generic Constraints
    {
        private T[] _items;
    }
}
