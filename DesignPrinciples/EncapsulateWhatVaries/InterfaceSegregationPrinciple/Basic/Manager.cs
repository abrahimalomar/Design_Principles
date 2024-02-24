using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Basic
{
    class Manager : Employee, IEmployee
    {
        public decimal CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateDeductions()
        {
            throw new NotImplementedException();
        }

        public decimal ContractHourlyCalculateSalary()
        {
            throw new NotImplementedException();
        }

        public decimal PartTimeCalculateSalary()
        {
            throw new NotImplementedException();
        }
        public decimal GetSalary()
        {
           return monthlySalary;
        }

       

        public override string PrintData()
        {
            return $"\n{nameof(Manager)}" +
                $"\n{name}" +
                $"\n{monthlySalary}";
        }
    }
}
