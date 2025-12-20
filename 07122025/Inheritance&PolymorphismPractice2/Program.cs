namespace Inheritance_PolymorphismPractice2
{
    public class Employee
    {
        public string _name { get; set; }

        public Employee(string name)
        {
            _name = name;
        }
        public virtual void CalculateSalary()
        {
            Console.WriteLine($"{_name} Salary calculation is not defined");
        }
    }

    public class FullTimeEmployee : Employee
    {
        private double _fixedSalary;
        public FullTimeEmployee(string name, double fixedSalary) : base(name)
        {
            _fixedSalary = fixedSalary;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"{_name}: Fulltime-employee salary is {_fixedSalary}$");
        }
    }

    public class PartimeEmployee : Employee
    {
        private double _hourlyRate;
        private double _hourWorked;
        public PartimeEmployee(string name, double hourlyRate, double hourWorked) : base(name)
        {
            _hourlyRate = hourlyRate;
            _hourWorked = hourWorked;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"{_name}: Partime-empolyee salary is {_hourlyRate * _hourWorked}$");
        }
    }

    public class InternEmployee : Employee
    {
        public InternEmployee(string name) : base(name)
        {

        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"{_name} Intern employee have no salary hehe");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fullTimeEmp = new FullTimeEmployee("Hien Minh Tran", 10000);
            Employee partimeEmp = new PartimeEmployee("Huy Quoc Dang", 36, 240.5);
            Employee internEmp = new InternEmployee("Phuong Minh Dang");

            fullTimeEmp.CalculateSalary();
            partimeEmp.CalculateSalary();
            internEmp.CalculateSalary();
        }
    }
}
