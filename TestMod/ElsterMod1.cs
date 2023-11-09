using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ...
[assembly: MelonInfo(typeof(ElsterMod1), "My first Elster mod", "latest", "Andy Blendermann")]
[assembly: MelonGame("", "")]

namespace TestMod
{
    // todo: create a namespace for mods and a namespace for each mod. Add using <namespace> to the
    // imports list.

    // todo: rename class to the function of your mod (Example: 'AddSword', 'CombatMode')

    public class ElsterMod1 : MelonMod
    {
        // todo: add code!
    }
}
