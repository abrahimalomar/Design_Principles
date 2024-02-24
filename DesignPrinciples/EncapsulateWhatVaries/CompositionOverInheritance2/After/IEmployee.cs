

namespace CompositionOverInheritance2.After
{

    public interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        decimal CalculateSalary();

    }
}
