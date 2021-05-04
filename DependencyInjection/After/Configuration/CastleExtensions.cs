using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DI.After
{
    public static class CastleExtensions
    {
        public static void Register<TInt, TImp>(this IWindsorContainer container)
            where TInt : class
            where TImp : TInt
        {
            container.Register(
                Component.For<TInt>()
                    .ImplementedBy<TImp>()
                    .LifeStyle.Transient);
        }
    }
}