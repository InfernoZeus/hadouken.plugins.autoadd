using System.Linq;
using Hadouken.Fx;
using Hadouken.Fx.Bootstrapping;
using Hadouken.Fx.JsonRpc;
using Hadouken.Plugins.AutoAdd.Bootstrapping;
using Hadouken.Plugins.AutoAdd.Models;
using Hadouken.Plugins.AutoAdd.Timers;

namespace Hadouken.Plugins.AutoAdd
{
    [Bootstrapper(typeof(AutoAddBootstrapper))]
    public class AutoAddPlugin : Plugin
    {
        private readonly IJsonRpcClient _rpcClient;
        private readonly ITimer _timer;

        public AutoAddPlugin(ITimerFactory timerFactory, IJsonRpcClient rpcClient)
        {
            _rpcClient = rpcClient;
            _timer = timerFactory.CreateTimer(CheckFolders);
        }

        public override void Load()
        {
            _timer.Start();
        }

        public override void Unload()
        {
            _timer.Stop();
        }

        private void CheckFolders()
        {
            var folders = _rpcClient.Call<Folder[]>("config.get", "autoadd.folders");
            if (folders == null || !folders.Any())
            {
                return;
            }


        }
    }
}
