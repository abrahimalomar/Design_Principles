using System;
using System.Collections.Generic;


namespace CompositionOverInheritance2.After
{
    public class Employee
    {
        public List<IEmployee> Iemployees = new List<IEmployee>();
        public decimal baseSalary { get; set; }

        public Employee()
        {
            Iemployees = new List<IEmployee>();
        }

        public void AddEmployee(List<IEmployee> employees)
        {
            foreach (var item in employees)
            {
                Iemployees.Add(item);
            }
        }
        public void PrintData()
        {
            foreach (var employeeType in Iemployees)
            {
                Console.WriteLine($"Employee Type: {employeeType.GetType().Name}");
                Console.WriteLine($"First Name: {employeeType.FirstName}");
                Console.WriteLine($"Last Name: {employeeType.LastName}");
                Console.WriteLine($"Salary: {employeeType.CalculateSalary()}");
                Console.WriteLine();
            }
        }
        public decimal CalculateTotalSalary()
        {
            decimal Total = 0;
            foreach (var item in Iemployees)
            {
                Total += item.CalculateSalary();
            }
            return Total;
        }
    }
}
