using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Basic
{
    class PartTimeEmployee : Employee, IEmployee
    {
        public decimal CalculateBonus()
        {
            return monthlySalary * (bonusPercentage / 100);
        }

        public decimal CalculateDeductions()
        {
            return monthlySalary * (deductionsPercentage / 100);
        }

        public decimal ContractHourlyCalculateSalary()
        {
            throw new NotImplementedException();
        }

        public decimal GetSalary()
        {
            throw new NotImplementedException();
        }

        public decimal PartTimeCalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }

        public override string PrintData()
        {
            return $"\n{nameof(PartTimeCalculateSalary)}" +
                 $"\n{name}" +
                 $"\n{monthlySalary}" +
                 $"\n{hourlyRate}" +
                 $"\n{hoursWorked}" +
                 $"\n{bonusPercentage}" +
                 $"\n{deductionsPercentage}";
        }
    }
}
