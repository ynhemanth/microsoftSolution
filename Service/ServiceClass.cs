using Repository;

namespace Service
{   
    public class ServiceClass :IService
    {
        IData _dataClass;
        public ServiceClass()
        {
            _dataClass = new DataClass();
        }

        public string FetchData()
        {
            return _dataClass.GetData();
        }
    }
}
