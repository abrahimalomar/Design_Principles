using DependencyInversionPrinciple.Edit;
using System;


namespace DependencyInversionPrinciple
{
    
    class EmailService: IMessageService
    {
        public string emailaddress { get; set; }
        

        public void Send()
        {

            Console.WriteLine($"send Email To  {emailaddress}");
        }
    }
}
