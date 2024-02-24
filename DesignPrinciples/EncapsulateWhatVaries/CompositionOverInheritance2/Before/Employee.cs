using System;
using System.Collections.Generic;
using System.Text;


namespace CompositionOverInheritance2.Before
{
    public class Employee
    {
        public  string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual decimal Salary { get; set; }

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public virtual decimal CalculateSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"\nType: Employee" +
                   $"\nFirst Name: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\nSalary: {CalculateSalary()}";
        }
    }
}

