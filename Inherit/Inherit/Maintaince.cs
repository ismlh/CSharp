namespace Inherit
{
    public class Maintaince : Employee
    {
        private decimal commisson = 1m;
        public Maintaince(int id, string Name, int looggedHours, decimal Wage) : base(id, Name, looggedHours, Wage) { }
        protected override decimal calcBaseSalary()
        {
            return base.calcBaseSalary();
        }
        protected override decimal calcNetSalary()
        {
            return base.calcNetSalary() * commisson;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCommision : {this.commisson}";
        }
    }
}
