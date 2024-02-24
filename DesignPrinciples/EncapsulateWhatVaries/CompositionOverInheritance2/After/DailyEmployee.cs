namespace CompositionOverInheritance2.After
{
    public class DailyEmployee:IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DaysWorked { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal CalculateSalary()
        {
            return DaysWorked * DailyPrice;
        }
    }
}
