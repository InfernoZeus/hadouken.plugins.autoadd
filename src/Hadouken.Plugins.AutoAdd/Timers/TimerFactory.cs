using System;

namespace Hadouken.Plugins.AutoAdd.Timers
{
    public class TimerFactory : ITimerFactory
    {
        public ITimer CreateTimer(Action callback)
        {
            return new Timer(callback);
        }
    }
}