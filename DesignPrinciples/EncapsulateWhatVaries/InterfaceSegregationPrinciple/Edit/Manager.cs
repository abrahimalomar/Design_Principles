using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Edit
{
    class Manager : Employee, ISalary
    {
        public decimal GetSalary()
        {
            return monthlySalary;
        }

        public override string PrintData()
        {
            return $"{nameof(Manager)}" +
                $"\nName: {name}" +
                $"\nMonthly Salary: {monthlySalary}" +
                $"\nHourly Rate: {hourlyRate}" +
                $"\nHours Worked: {hoursWorked}" +
                $"\nBonus Percentage: {bonusPercentage}" +
                $"\nDeductions Percentage: {deductionsPercentage}";
        }


    }
}
