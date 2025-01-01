using Oxide.Game.Rust;

namespace Oxide.Ext.SuperNPC.Plugins
{
    public class SuperNPCPluginLoader : RustPluginLoader
    {
        public override Type[ ] CorePlugins => new[ ] 
        { 
            typeof(SuperNPCExtensionCore), typeof(NPC.Motor.Movement),
            typeof(SuperNPCExtensionCore), typeof(NPC.CoreNPC),
            typeof(SuperNPCExtensionCore), typeof(NPC.Perception.SoundSense),
            typeof(SuperNPCExtensionCore), typeof(NPC.Perception.TouchSense),
            typeof(SuperNPCExtensionCore), typeof(NPC.Perception.VisionSense),
        };
    }
}
