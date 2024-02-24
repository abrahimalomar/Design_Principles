using System;


namespace InterfaceSegregationPrinciple.Basic
{
    class FullTimeEmployee : Employee, IEmployee
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
            throw new NotSupportedException();
        }

        public decimal GetSalary()
        {
            return monthlySalary;
        }

        public decimal PartTimeCalculateSalary()
        {
            throw new NotImplementedException();
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
