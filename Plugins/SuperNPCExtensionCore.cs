using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;

namespace Oxide.Ext.SuperNPC.Plugins
{
    internal class SuperNPCExtensionCore : SuperNPCPlugin
    {
        public static SuperNPCExtensionCore _instance;

        public SuperNPCExtensionCore()
        {
            Name = "Super NPC";
            Title  = "Super NPC";
        }

        [HookMethod(nameof(Init))]
        public void Init()
        {
            _instance = this;
            AddCovalenceCommand(["snpc"], nameof(SACCommand));
        }

        [HookMethod(nameof(SACCommand))]
        private void SACCommand(IPlayer player, string cmd, string[ ] args)
        {
        }
    }
}
