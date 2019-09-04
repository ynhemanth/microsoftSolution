using Repository;
using Unity;
using Unity.Extension;

namespace Service
{
    public class SetupExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IData, DataClass>();
        }
    }
}
