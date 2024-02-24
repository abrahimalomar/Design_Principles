

namespace SingleResponsibilityPrinciple
{
    class AcoountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public AcoountModel(int id, string name, string email, decimal balance)
        {
            Id = id;
            Name = name;
            Email = email;
            Balance = balance;
        }
    }
}
