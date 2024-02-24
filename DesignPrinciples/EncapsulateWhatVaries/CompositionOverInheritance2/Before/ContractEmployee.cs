namespace CompositionOverInheritance2.Before
{
    class ContractEmployee : Employee
    {
        public int ContractDuration { get; set; }

        public ContractEmployee(int contractDuration, string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
            ContractDuration = contractDuration;
        }

        public override decimal CalculateSalary()
        {
 
            return Salary * ContractDuration;
        }

        public override string ToString()
        {
            return $"\nType: Contract Employee" +
                   $"\nFirst Name: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\nContract Duration: {ContractDuration} months" +
                   $"\nSalary: {CalculateSalary()}";
        }
    }
}

