using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Basic
{
    class ContractHourlyEmployee : Employee, IEmployee
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
            return hourlyRate * hoursWorked;
        }

        public decimal GetSalary()
        {
            throw new NotImplementedException();
        }

        public decimal PartTimeCalculateSalary()
        {
            throw new NotImplementedException();
        }

        public override string PrintData()
        {
            return $"\n{nameof(ContractHourlyEmployee)}" +
                $"\n{name}" +
                $"\n{monthlySalary}" +
                $"\n{hourlyRate}" +
                $"\n{hoursWorked}" +
                $"\n{bonusPercentage}" +
                $"\n{deductionsPercentage}";
        }
    }
}
