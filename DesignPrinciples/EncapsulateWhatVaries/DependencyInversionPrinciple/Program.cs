using DependencyInversionPrinciple.Edit;
using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var customers =Repository.list;
            foreach (var customer in customers)
            {
                List<IMessageService> messageServices = new List<IMessageService>()
            {

                new EmailService
                {
                    emailaddress=customer.EmailAddress,
                },
                new SmsService
                {
                    MobileNo=customer.MobileNo
                },

        };
                var notfactinservices = new NotificationService(messageServices);
                notfactinservices.Notify();
            }
            


            

        }
    }
}
