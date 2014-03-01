using System;

namespace Hadouken.Plugins.AutoAdd.Timers
{
    public interface ITimerFactory
    {
        ITimer CreateTimer(Action callback);
    }
}
