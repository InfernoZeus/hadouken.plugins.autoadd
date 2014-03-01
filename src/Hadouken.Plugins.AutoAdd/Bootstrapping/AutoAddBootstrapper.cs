using Hadouken.Fx.Bootstrapping.TinyIoC;
using Hadouken.Plugins.AutoAdd.Timers;

namespace Hadouken.Plugins.AutoAdd.Bootstrapping
{
    public class AutoAddBootstrapper : TinyIoCBootstrapper
    {
        protected override void RegisterComponents(TinyIoCContainer container)
        {
            base.RegisterComponents(container);

            container.Register<ITimerFactory, TimerFactory>();
        }
    }
}
