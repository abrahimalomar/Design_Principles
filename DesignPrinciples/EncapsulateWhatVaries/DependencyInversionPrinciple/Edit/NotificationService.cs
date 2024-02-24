using DependencyInversionPrinciple.Edit;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class NotificationService
    {
        private readonly List<IMessageService>  _message;
        public NotificationService(List<IMessageService> message)
        {
            _message = message;
        }
        public void Notify()
        {
            foreach (var item in _message)
            {
                item.Send();
            }
        }

       
    }
}
