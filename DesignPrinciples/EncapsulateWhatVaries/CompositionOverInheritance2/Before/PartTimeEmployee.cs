namespace CompositionOverInheritance2.Before
{
    class PartTimeEmployee : HourlyEmployee
    {
        public PartTimeEmployee(int hoursWorked, int hourlyRate, string firstName, string lastName)
             : base(hoursWorked,hourlyRate,firstName, lastName)
        {
            
        }


        public override decimal CalculateSalary()
        {
    
            return HoursWorked * HourlyRate; 
        }

        public override string ToString()
        {
            return $"\nType: PartTime Employee" +
                   $"\nFirst Name: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\nHours Worked: {HoursWorked}" +
                   $"\nSalary: {CalculateSalary()}";
        }
    }
}

