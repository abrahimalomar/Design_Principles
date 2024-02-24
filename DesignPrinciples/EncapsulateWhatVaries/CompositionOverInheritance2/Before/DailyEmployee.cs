namespace CompositionOverInheritance2.Before
{
    class DailyEmployee : Employee
    {
        public int DaysWorked { get; set; }

        public DailyEmployee(int daysWorked, string firstName, string lastName, decimal salary)
            : base(firstName, lastName, salary)
        {
            DaysWorked = daysWorked;
        }

        public override decimal CalculateSalary()
        {
     
            return Salary * DaysWorked * 0.9m;
        }

        public override string ToString()
        {
            return $"\nType: Daily Employee" +
                   $"\nFirst Name: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\nDays Worked: {DaysWorked}" +
                   $"\nSalary: {CalculateSalary()}";
        }
    }
}

