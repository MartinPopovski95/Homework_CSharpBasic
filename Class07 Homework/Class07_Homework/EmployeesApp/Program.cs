using Domain.Enums;
using Domain.Models;

Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);
employee.PrintInfo();

double salary = employee.GetSalary();

SalesPerson salesPerson = new SalesPerson("Stefan", "Stefanovski", 0);
salesPerson.AddSuccessRevenue(2500);
Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Nikola", "Nikolovski", 600);
manager.PrintInfo(); //inherited from Employee
manager.AddBonus(100);
Console.WriteLine(manager.GetSalary());
manager.AddBonus(150);
Console.WriteLine(manager.GetSalary());

Console.WriteLine();
Console.WriteLine("======HOMEWORK======");

Manager bob = new Manager("Bob", "Bobert", 1000);
Manager rick = new Manager("Rick", "Rickert", 1100);

Contractor mona = new Contractor("Mona", "Monalisa", 120, 10, bob);
Contractor igor = new Contractor("Igor", "Igorsky", 100, 12, rick);

SalesPerson lea = new SalesPerson("Lea", "Leova", 3000);

Employee[] company = new Employee[] { bob, rick, mona, igor, lea };

CEO ceoRon = new CEO("Ron", "Ronsky", 1500, company, 70);
ceoRon.AddSharesPrice(20);

Console.WriteLine("CEO:");
ceoRon.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceoRon.GetSalary()}");
ceoRon.PrintEmployees();


Console.WriteLine();
Console.WriteLine(mona.CurrentPosition());
Console.WriteLine($"Mona's salary: {mona.GetSalary()}");