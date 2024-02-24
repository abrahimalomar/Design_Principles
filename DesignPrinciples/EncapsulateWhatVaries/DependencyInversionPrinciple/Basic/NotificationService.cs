using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Basic
{
    class NotificationService
    {
        private readonly EmailService emailAddress;
        private readonly SmsService smsService;
        private readonly customer customer;
        public NotificationService(customer customer)
        {
            emailAddress = new EmailService
            {
                emailaddress = customer.EmailAddress
            };
            smsService = new SmsService
            {
                MobileNo = customer.MobileNo
            };
        }
        public void Notify()
        {
            emailAddress.send();
            smsService.sent();
        }
    }
}
