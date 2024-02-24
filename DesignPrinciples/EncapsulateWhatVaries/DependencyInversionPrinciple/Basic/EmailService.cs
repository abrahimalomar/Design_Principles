using System;


namespace DependencyInversionPrinciple.Basic
{
    class EmailService
    {
        public string emailaddress { get; set; }
        public void send()
        {
            Console.WriteLine($"send Email To  {emailaddress}");
        }
    }
}
