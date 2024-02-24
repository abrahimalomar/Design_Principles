using System;


namespace SingleResponsibilityPrinciple
{
    class EmailClient
    {
        public void SendEmail(AcoountModel acoount,string transactionMessage,DateTime dateTime)
        {
            Console.WriteLine(
               $"\n\n\t\t To: {acoount.Email}" +
               $"\n\t\t Subject: Fake Bank Account Activity" +
               $"\n\n\t\t Dear {acoount.Name}," +
               $"\n\n\t\t\t A recent activity on your account occures at {dateTime.ToString("yyyy-MM-dd hh:mm")}" +
               "\n\t\t\t\t ===> {0}" +
               $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
               $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
