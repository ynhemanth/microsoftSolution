using Service;

namespace presentation
{
    public static class Starter
    {
        public static void Init()
        {
            Setup.Register<IService, ServiceClass>();
            Setup.AddExtension<SetupExtension>();
        }
    }
}
