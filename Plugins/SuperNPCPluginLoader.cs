using Oxide.Game.Rust;

namespace Oxide.Ext.SuperNPC.Plugins
{
    public class SuperNPCPluginLoader : RustPluginLoader
    {
        public override Type[ ] CorePlugins => new[ ] 
        { 
            typeof(SuperNPCExtensionCore),
            typeof(NPC.Motor.Movement),
            typeof(NPC.CoreNPC),
            typeof(NPC.Perception.SoundSense),
            typeof(NPC.Perception.TouchSense),
            typeof(NPC.Perception.VisionSense),
        };
    }
}
