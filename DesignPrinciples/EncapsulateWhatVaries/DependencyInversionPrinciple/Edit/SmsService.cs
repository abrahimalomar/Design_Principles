using System;
using DependencyInversionPrinciple.Edit;

namespace DependencyInversionPrinciple
{
    class SmsService:IMessageService
    {
        public string MobileNo { get; set; }

        public void Send()
        {
            Console.WriteLine($"Send SMS To MobileNo  {MobileNo}");
        }

    }
}
