using System;
// There is 3 Generic Delegates (action ,func,predicate)
/// <summary>
/// --Action : -Return Void
///            -take 16 in parametares
/// --func :   -Return generic(out)
///            -take 16 in parametares
/// --predicate : -Return bool
///            -take 1 in parametares
/// </summary>
namespace bulit_In_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action = Print;
            action(1);
            Func<int, int, int> func = Add;
            Console.WriteLine(   func(1, 2));
            Predicate<int> predicate = Check;
            Console.WriteLine(predicate(1));
            Console.ReadKey();
        }
        static void Print(int n) => Console.WriteLine(n);
        static int Add(int n, int n1) => n + n1;
        static bool Check(int n) => n >0;
    }
}
