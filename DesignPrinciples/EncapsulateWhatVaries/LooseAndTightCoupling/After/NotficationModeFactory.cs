namespace LooseAndTightCoupling.After
{
    class NotficationModeFactory
    {
        public static INotfcationModel Create(NotficationMode mode)
        {
            switch (mode)
            {
                case NotficationMode.Email:
                    return new EmailService();
                case NotficationMode.SMS:
                    return new SmsService();
                default:
                    return new EmailService();
            }
        }
    }
}
