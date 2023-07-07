using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
           {
                new Employee{Id=1,Name="Islam",Age=27,Gender='M' },
                new Employee{Id=2,Name="Ali",Age=26,Gender='M' },
                new Employee{Id=3,Name="Marwan",Age=19,Gender='M' },
                new Employee{Id=4,Name="Marwa",Age=20,Gender='f' },
                new Employee{Id=5,Name="Meran",Age=21,Gender='f' },
                new Employee{Id=6,Name="Salwa",Age=23,Gender='f' },
           };
            Report report = new Report();
            #region Old Way 
            //report.AgeEqual20OrLessThan20(emps);
            //report.AgeBetween21And25(emps);
            //report.AgeCreaterThan25(emps);
            #endregion
            report.EmpsAge(emps, "Age < = 20", e => e.Age <= 20);
            report.EmpsAge(emps, "Age < 20 And < = 25", e => e.Age > 20&&e.Age<=25);
            report.EmpsAge(emps, "Age >  25", e => e.Age > 25);
            Console.ReadKey();
        }
    }
}
