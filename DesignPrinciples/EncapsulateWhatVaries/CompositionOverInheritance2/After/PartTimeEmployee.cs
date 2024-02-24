namespace CompositionOverInheritance2.After
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HoursWorked { get; set; } 
        public decimal HourlyRate { get; set; } 

        public decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
