using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Islam" },
                new Employee { Id = 2, Name = "Ahmed" },
                new Employee { Id = 3, Name = "Ali" },
                new Employee { Id = 4, Name = "Marwa" }
            };
            employees.Add(new Employee { Id = 6, Name = "Ali" });
            employees.AddRange(new List<Employee> { new Employee { Id = 7, Name = "A" }, new Employee { Id = 8, Name = "A" } });
            employees.RemoveAll(x => x.Name == "Islam");
            employees.Remove(new Employee { Id = 7, Name = "A" });
            employees.Insert(4, new Employee { Id = 7, Name = "A" });
            foreach (var item in employees)
            {
                Console.WriteLine(item);
                Console.WriteLine($"count {employees.Count}");
                Console.WriteLine($"count {employees.Capacity}");
            }
            
            Console.ReadKey();
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            // to make refrences Equal
            public override int GetHashCode()
            {
                var hash = 19;

                unchecked
                {
                    hash = 19 * 3 * Id.GetHashCode();
                    hash = 19 * 3 * Name.GetHashCode();
                }
                return hash;
            }
            public override bool Equals(object obj)
            {
                var emp = obj as Employee;
                return this.Id.Equals(emp.Id)
                    && this.Id.Equals(emp.Id);
            }
            public override string ToString()
            {
                return $"Id: {this.Id} Name : {this.Name}";
            }
        }
    }
}
