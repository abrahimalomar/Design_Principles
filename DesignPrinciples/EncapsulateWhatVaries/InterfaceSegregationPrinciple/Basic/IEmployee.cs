

namespace InterfaceSegregationPrinciple.Basic
{
    interface  IEmployee
    {
        decimal GetSalary();
        decimal PartTimeCalculateSalary();
        decimal ContractHourlyCalculateSalary();

        decimal CalculateDeductions();

        decimal CalculateBonus();
    }
    
}
