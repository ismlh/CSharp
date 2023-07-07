namespace Inherit
{
    public  abstract class Employee
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected int LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public Employee(int id, string Name, int looggedHours, decimal Wage)
        {
            this.ID = id;
            this.Name = Name;
            this.LoggedHours = looggedHours;
            this.Wage = Wage;
        }
        protected virtual decimal calcBaseSalary()
        {
            return this.LoggedHours * this.Wage;
        }
        protected virtual decimal calcNetSalary()
        {
            return this.LoggedHours * this.Wage;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inherit.", "");
            return $"{type}" +
                $"\nID : {this.ID}" +
                $"\nName : {this.Name}" +
                $"\nLoggedHours : {this.LoggedHours}" +
                $"\nWage : {this.Wage}" +
                $"\nBaseSalary : {this.calcBaseSalary()}" +
                 $"\nNetSalary : {this.calcNetSalary()}";
        }
    }
}
