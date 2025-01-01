/// This class defines and initialises all the logic for Super NPC.
/// 

using Oxide.Core.Plugins;
using Oxide.Ext.SuperNPC.NPC.Motor;
using Oxide.Ext.SuperNPC.NPC.Perception;
using Oxide.Ext.SuperNPC.Plugins;
using UnityEngine;

namespace Oxide.Ext.SuperNPC.NPC
{
    public class NPC : SuperNPCPlugin
    {
        public void CreateNPC()
        {

        }

        public class CoreNPC : MonoBehaviour
        {
            NPCPlayer _npc;
            private Movement _movement;
            private SoundSense _soundSense;
            private TouchSense _touchSense;
            private VisionSense _visionSense;

            private void Awake()
            {

            }
        }
    }
}
