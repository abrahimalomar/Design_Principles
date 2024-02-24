using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Edit
{
    class ContractHourlyEmployee : Employee, IContractHourly, ICalculateBonus, ICalculateDeductions
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

        public override string PrintData()
        {
            return $"{nameof(ContractHourlyEmployee)}" +
                $"\nName: {name}" +
                $"\nMonthly Salary: {monthlySalary}" +
                $"\nHourly Rate: {hourlyRate}" +
                $"\nHours Worked: {hoursWorked}" +
                $"\nBonus Percentage: {bonusPercentage}" +
                $"\nDeductions Percentage: {deductionsPercentage}";
        }

    }
}
