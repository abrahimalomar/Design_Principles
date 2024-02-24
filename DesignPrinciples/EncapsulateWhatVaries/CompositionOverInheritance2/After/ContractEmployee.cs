namespace CompositionOverInheritance2.After
{
    public  class ContractEmployee:IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Contract Duration per month
        public int ContractDuration { get; set; }
      
        public decimal BaseSalary { get; set; }
        public decimal CalculateSalary()
        {
            return ContractDuration * BaseSalary;
        }
    }
}
