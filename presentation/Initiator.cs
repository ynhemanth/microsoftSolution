using Service;

namespace presentation
{
    public class Initiator
    {
        IService _serviceClass;
        public Initiator()
        {
            _serviceClass = new ServiceClass();
        }
        public string FetchData()
        {
            return _serviceClass.FetchData();
        }
    }
}
