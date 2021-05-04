using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace DI.After
{
    public class RoyalFamilyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register<IKing, King>();
            container.Register<IFinancier, Financier>();
            container.Register<ISecretary, ModernSecretary>();
        }
    }
}