using Domain.Enums;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares)
            :base(firstName, lastName, RoleEnum.Manager, salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = 0;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }


        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
