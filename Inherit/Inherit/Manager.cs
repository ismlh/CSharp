namespace Inherit
{
    public class Manager:Employee
    {
        private decimal  commisson=1.5m;
        public Manager(int id, string Name, int looggedHours, decimal Wage):base(id,Name,looggedHours,Wage) { }
        protected override decimal calcBaseSalary()
        {
            return base.calcBaseSalary();
        }
        protected override decimal calcNetSalary()
        {
            return base.calcNetSalary()* commisson;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCommision : {this.commisson}" ;
        }
    }
}
