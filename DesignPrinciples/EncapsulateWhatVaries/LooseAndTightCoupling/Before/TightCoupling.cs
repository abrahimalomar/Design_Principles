using System;

namespace LooseAndTightCoupling.Before
{
    
    
    class EmailService
    {
        public void Send()
        {
            Console.WriteLine("Email Send");
        }
    }
    class SmsService
    {
        public void Send()
        {
            Console.WriteLine("SMS Send");
        }
    }
    class NotfcationService
    {
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;
        public NotfcationService(EmailService emailService, SmsService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }
        public void Notify()
        {
            _emailService.Send();
            _smsService.Send();
        }
    }
    
}
