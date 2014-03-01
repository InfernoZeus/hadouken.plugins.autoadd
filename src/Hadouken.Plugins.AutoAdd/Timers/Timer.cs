using System;

namespace Hadouken.Plugins.AutoAdd.Timers
{
    public class Timer : ITimer
    {
        private readonly Action _callback;

        public Timer(Action callback)
        {
            _callback = callback;
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}