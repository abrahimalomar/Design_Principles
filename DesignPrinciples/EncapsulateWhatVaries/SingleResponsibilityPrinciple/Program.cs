



namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountService accountService = new AccountService();
            AcoountModel acoount = new AcoountModel(1, "Ibrahim", "Ibrahim@gmail.com", 200);
            //accountService.Deposit(acoount, 200);

            accountService.WithDraw(acoount, 400);

        }
  

        /*
        public class Acoount
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public decimal Balance { get; set; }

            public Acoount(int id,string name,string email,decimal balance)
            {
                Id = id;
                Name = name;
                Email = email;
                Balance = balance;
            }

            public void MackTranction(decimal amount)
            {
                var transactionMessage = "";

                if (amount<0)
                {
                    if (Balance<Math.Abs(amount))
                    {
                        transactionMessage =
                          $"OVERDRAFT when trying to withdraw " +
                          $"{ Math.Abs(amount).ToString("C2")}," +
                          $" current balance {Balance.ToString("C2")}";

                    }
                    else
                    {
                        Balance -= amount;
                        transactionMessage =
                            $"OK Withdraw { Math.Abs(amount).ToString("C2")}" +
                            $", current balance {Balance.ToString("C2")}";
                    }

                }
          

                else
                {

                    if (amount > 0)
                    {
                        this.Balance += amount;

                        transactionMessage =
                            $"OK Deposit {amount.ToString("C2")}" +
                            $", current balance {this.Balance.ToString("C2")}";
                    }
                }
               
            }
        }
       */
    }
}
