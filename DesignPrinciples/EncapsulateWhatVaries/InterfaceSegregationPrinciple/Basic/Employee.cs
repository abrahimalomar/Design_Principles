using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Basic
{
   abstract  class Employee
    {
        public  int Id { get; set; }
        public string name;
        public decimal monthlySalary;
        public decimal hourlyRate;
        public int hoursWorked;
        public decimal deductionsPercentage; // نسبة الحسم
        public decimal bonusPercentage; // نسبة الزيادة
        public abstract string PrintData();

    }
}
