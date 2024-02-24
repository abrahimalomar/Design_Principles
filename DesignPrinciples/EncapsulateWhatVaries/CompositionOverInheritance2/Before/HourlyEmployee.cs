namespace CompositionOverInheritance2.Before
{
    public class HourlyEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public HourlyEmployee(int hoursWorked,int hourlyRate, string firstName, string lastName)
            : base(firstName, lastName, 0)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
     
            return HoursWorked * HourlyRate;
        }

        public override string ToString()
        {
            return $"\nType: Hourly Employee" +
                   $"\nFirst Name: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\nHours Worked: {HoursWorked}" +
                   $"\nSalary: {CalculateSalary()}";
        }
    }
}

