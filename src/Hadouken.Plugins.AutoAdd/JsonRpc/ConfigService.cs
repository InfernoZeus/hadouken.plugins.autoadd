using System.IO;
using System.Reflection;
using Hadouken.Fx.JsonRpc;
using Hadouken.Plugins.AutoAdd.Models;

namespace Hadouken.Plugins.AutoAdd.JsonRpc
{
    public class ConfigService : IJsonRpcService
    {
        private readonly IJsonRpcClient _rpcClient;
        private static readonly string Namespace = "Hadouken.Plugins.AutoAdd.UI";
        private static readonly Assembly Asm = typeof(ConfigService).Assembly;

        public ConfigService(IJsonRpcClient rpcClient)
        {
            _rpcClient = rpcClient;
        }

        [JsonRpcMethod("autoadd.config.get")]
        public Folder[] GetConfig()
        {
            return _rpcClient.Call<Folder[]>("config.get", "autoadd.folders");
        }

        [JsonRpcMethod("autoadd.config.set")]
        public bool SetConfig(Folder[] folders)
        {
            _rpcClient.Call<Folder[]>("config.set", new object[] {"autoadd.folders", folders});
            return true;
        }

        [JsonRpcMethod("autoadd.config.template")]
        public byte[] GetTemplate()
        {
            var resourceName = string.Concat(Namespace, ".config.ejs");
            using (var resource = Asm.GetManifestResourceStream(resourceName))
            using (var ms = new MemoryStream())
            {
                if (resource == null)
                {
                    return null;
                }

                resource.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}