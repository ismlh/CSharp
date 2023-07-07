using System;

namespace OpreatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new(20);
            Money money1 = new(10);
            Money money2 = money + money1;
            Money money3 = money - money1;
            Money money4 = money * money1;
            Money money5 = money / money1;
            var money6 = money > money1;
            var money7 = money < money1;
            var money8 = money == money1;
            var money9 = money != money1;
            Console.WriteLine($"m + m1 = {money2.Amount}");
            Console.WriteLine($"m - m1 = {money3.Amount}");
            Console.WriteLine($"m * m1 = {money4.Amount}");
            Console.WriteLine($"m / m1 = {money5.Amount}");
            Console.WriteLine($"m > m1 = {money6}");
            Console.WriteLine($"m < m1 = {money7}");
            Console.WriteLine($"m == m1 = {money8}");
            Console.WriteLine($"m != m1 = {money9}");
            Console.ReadKey();
        }
    }
}
