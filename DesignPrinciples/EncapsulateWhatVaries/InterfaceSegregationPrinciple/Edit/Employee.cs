using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Edit
{
   abstract  class Employee
    {
        public  int Id { get; set; }
        public string name;
        public decimal monthlySalary;
        public decimal hourlyRate;
        public int hoursWorked;
        public decimal deductionsPercentage; 
        public decimal bonusPercentage; 
        public abstract string PrintData();

    }
}
