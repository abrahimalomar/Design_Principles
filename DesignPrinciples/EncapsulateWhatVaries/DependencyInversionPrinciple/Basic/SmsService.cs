using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Basic
{
    class SmsService
    {
        public string MobileNo { get; set; }
        public void sent()
        {
            Console.WriteLine($"Send SMS To MobileNo  {MobileNo}");
        }
    }
}
