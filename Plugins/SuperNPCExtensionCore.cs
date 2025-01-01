using Oxide.Core;
using Oxide.Core.Plugins;
using Oxide.Game.Rust.Libraries;

namespace Oxide.Ext.SuperNPC.Plugins
{
    internal class SuperNPCExtensionCore : SuperNPCPlugin
    {
        public SuperNPCExtensionCore()
        {
            Name = "Super NPC";
            Title  = "Super NPC";
        }

        public static SuperNPCExtensionCore _instance;
        private readonly Command cmd = Interface.Oxide.GetLibrary<Command>();
       
        [HookMethod(nameof(Init))]
        private void Init()
        {
            _instance = this;
            cmd.AddChatCommand("snpc", this, nameof(SACCommand));
        }

        [HookMethod(nameof(SACCommand))]
        private void SACCommand(BasePlayer player, string cmd, string[ ] args)
        {
        }
    }
}
