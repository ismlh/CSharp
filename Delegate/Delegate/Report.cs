using System;

namespace Delegate
{
    public  class Report
    {
        //delegate
        public delegate bool AgeCondations(Employee employees);
        public void EmpsAge(Employee[] employee,string Title,AgeCondations condation)
        {
            System.Console.WriteLine(Title);
            System.Console.WriteLine("----------------------------");
            foreach (var e in employee)
            {
                if (condation(e))
                    Console.WriteLine($"Id:{e.Id} Name:{e.Name} Age:{e.Age} Gender:{e.Gender}");
            }
            Console.WriteLine("\n\n");
        }
        //#region Old Way
        //public void AgeEqual20OrLessThan20(Employee[] employee)
        //{
        //    System.Console.WriteLine("Age Equal 20 Or Less Than 20");
        //    System.Console.WriteLine("----------------------------");
        //    foreach (var e in employee)
        //    {
        //        if (e.Age <= 20)
        //            Console.WriteLine($"Id:{e.Id} Name:{e.Name} Age:{e.Age} Gender:{e.Gender}");
        //    }
        //    Console.WriteLine("\n\n");
        //}
        //public void AgeBetween21And25(Employee[] employee)
        //{
        //    System.Console.WriteLine("Age Betwween 21 And 25");
        //    System.Console.WriteLine("----------------------------");
        //    foreach (var e in employee)
        //    {
        //        if (e.Age > 20 && e.Age <= 25)
        //            Console.WriteLine($"Id:{e.Id} Name:{e.Name} Age:{e.Age} Gender:{e.Gender}");
        //    }
        //    Console.WriteLine("\n\n");
        //}
        //public void AgeCreaterThan25(Employee[] employee)
        //{
        //    System.Console.WriteLine("Age Creater than  25");
        //    System.Console.WriteLine("----------------------------");
        //    foreach (var e in employee)
        //    {
        //        if (e.Age > 25)
        //            Console.WriteLine($"Id:{e.Id} Name:{e.Name} Age:{e.Age} Gender:{e.Gender}");
        //    }
        //}
        //#endregion
    }
}