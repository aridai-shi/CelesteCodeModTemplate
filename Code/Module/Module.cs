using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Mod.Template
{
    public class Module : EverestModule {

        // Only one alive module instance can exist at any given time.
        public static Module Instance;

        public Module() {
            Instance = this;
        }

        // Set up any hooks, event handlers and your mod in general here.
        // Load runs before Celeste itself has initialized properly.
        public override void Load() {
        }

        // Optional, initialize anything after Celeste has initialized itself properly.
        public override void Initialize() {
        }

        // Optional, do anything requiring either the Celeste or mod content here. 
        // Usually involves Spritebanks or custom particle effects.
        public override void LoadContent(bool firstLoad) {
        }

        // Unload the entirety of your mod's content. Free up any native resources.
        public override void Unload() {
        }

    }
}

