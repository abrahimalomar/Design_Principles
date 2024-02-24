namespace LooseAndTightCoupling.After
{

    class NotfcationService
    {
        private readonly INotfcationModel _notfcationModel;
        public NotfcationService(INotfcationModel notfcationModel)
        {
            _notfcationModel = notfcationModel;
        }
        public void Notify()
        {
            _notfcationModel.Send();
        }
    }
}
