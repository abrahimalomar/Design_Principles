using System;


namespace SingleResponsibilityPrinciple
{
    class AccountService
    {

        public void Deposit(AcoountModel acoount,decimal amount)
        {
            var transactionMasseg = "";
            if (amount>0)
            {
                acoount.Balance += amount;
                transactionMasseg =
                $"Ok Deposit {amount.ToString("C")}," +
                $",current balance {acoount.Balance.ToString("C")} ";
            }
            var email =new EmailClient();
            email.SendEmail(acoount, transactionMasseg, DateTime.Now);
        }

        public void WithDraw(AcoountModel acoount,decimal amount)
        {
            var transactionMasseg = "";
            //WithDraw
            if (acoount.Balance<amount)
            {
                transactionMasseg = $"Please retry, the requested amount" +
                    $" is greater than your balance " +
                    $",current balance {acoount.Balance.ToString("C")}";
            }
            else
            {
                acoount.Balance -= amount;
                transactionMasseg =
               $"Ok WithDraw {amount.ToString("C")}," +
               $",current balance {acoount.Balance.ToString("C")} ";
            }
            var email = new EmailClient();
            email.SendEmail(acoount, transactionMasseg, DateTime.Now);

        }
    }
}
