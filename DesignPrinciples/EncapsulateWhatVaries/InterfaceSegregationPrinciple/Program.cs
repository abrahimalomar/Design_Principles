using InterfaceSegregationPrinciple.Edit;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                name = "Ibrahim Alomar",
                monthlySalary = 5000,
                bonusPercentage = 5,
                deductionsPercentage = 2
            };

            ContractHourlyEmployee contractHourlyEmployee = new ContractHourlyEmployee
            {
                name = "Omar Al-Omar",
                hourlyRate = 20,
                hoursWorked = 40
            };

            Manager manager = new Manager
            {
                name = "Khled Omar",
                monthlySalary = 8000,
                bonusPercentage = 8
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                name = "Ziad Alomar",
                monthlySalary = 3000,
                hourlyRate = 15,
                hoursWorked = 25,
                bonusPercentage = 3,
                deductionsPercentage = 1
            };





            Console.WriteLine(fullTimeEmployee.PrintData());
            Console.WriteLine();
            Console.WriteLine(contractHourlyEmployee.PrintData());
            Console.WriteLine();
            Console.WriteLine(partTimeEmployee.PrintData());
            Console.WriteLine();
            Console.WriteLine(manager.PrintData());
            Console.WriteLine();

            Console.WriteLine($"Full-Time Employee Salary: {fullTimeEmployee.GetSalary()} | Bonus: {fullTimeEmployee.CalculateBonus()} | Deductions: {fullTimeEmployee.CalculateDeductions()}");
            Console.WriteLine($"Contract Hourly Employee Salary: {contractHourlyEmployee.ContractHourlyCalculateSalary()} | Bonus: {contractHourlyEmployee.CalculateBonus()} | Deductions: {contractHourlyEmployee.CalculateDeductions()}");
            Console.WriteLine($"Manager Salary: {manager.GetSalary()} | Bonus: {manager.GetSalary()}");
            Console.WriteLine($"Part-Time Employee Salary: {partTimeEmployee.PartTimeCalculateSalary()} | Bonus: {partTimeEmployee.CalculateBonus()} | Deductions: {partTimeEmployee.CalculateDeductions()}");

        }
    }
}

   

