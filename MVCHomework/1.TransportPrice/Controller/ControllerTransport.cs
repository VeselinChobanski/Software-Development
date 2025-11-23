namespace _1.TransportPrice
{
    public class ControllerTransport
    {
        ServiceTransport _serviceTransport;

        public ControllerTransport(ServiceTransport serviceTransport)
        {
            _serviceTransport = serviceTransport;
        }

        public double Execute(ModelInput model)
        {
            _serviceTransport.CalculateAll(model);
           return _serviceTransport.ChooseOne();
        }

    }
}
