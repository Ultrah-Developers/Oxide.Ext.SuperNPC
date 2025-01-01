using Oxide.Core.Plugins;

namespace Oxide.Ext.SuperNPC.Plugins
{
    public class SuperNPCPlugin : CSPlugin
    {
        protected SuperNPCPlugin()
        {
            Author = SuperNPCExtension._author;
            Version = SuperNPCExtension._extensionVersion;
        }
    }
}
