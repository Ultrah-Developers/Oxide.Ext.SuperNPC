﻿using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.SuperNPC
{
    public class SuperNPCExtension : Extension
    {
        public SuperNPCExtension(ExtensionManager manager) : base(manager) { }

        public static string _name = "Super NPC";
        public static string _author = "Ultrah Servers";
        public static VersionNumber _extensionVersion = new(0, 0, 1);

        // Initialise extension details
        public override string Name => _name;
        public override string Author => _author;
        public override VersionNumber Version => _extensionVersion;

        // Called when the extension is loaded
        public override void OnModLoad()
        {
        }
    }
}