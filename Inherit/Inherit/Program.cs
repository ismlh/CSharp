using System;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(100, "Islam", 120, 20);
            Developer developer = new Developer(101, "Mohamed", 100, 15);
            Maintaince maintaince = new Maintaince(102, "Ahmed", 80, 10);
            Sales  sales = new Sales(103, "Islam", 70, 10);
            Employee[] employees = { manager, developer, maintaince, sales };
            foreach (var employee in employees)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(employee);
            }
            Console.ReadKey();
        }
    }
}
