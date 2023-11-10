using FlashlightMod;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

// ...
[assembly: MelonInfo(typeof(AddFlashlight), "My first Elster mod", "latest", "Andy Blendermann")]
[assembly: MelonGame("", "")]

namespace FlashlightMod
{
    // todo: create a namespace for mods and a namespace for each mod. Add using <namespace> to the
    // imports list.

    // todo: rename class to the function of your mod (Example: 'AddSword', 'CombatMode')

    public class AddFlashlight : MelonMod
    {
        public override void OnUpdate()
        {
            // comment this out because we need to override it in the game
            // base.OnUpdate();

            bool keyUp = Input.GetKeyUp(KeyCode.F);

            if (!ElsterFlashLight.on) {
                Cheats.forceLight = true;
                ElsterFlashLight.on = true;
            }
            else {
                ElsterFlashLight.on = false;
            }

            GameObject gameObjectPrereq = GameObject.Find("__Prerequisites__");

            if (gameObjectPrereq != null && SceneManager.GetActiveScene() != null) {
                GameObject gameObjectCharacterOrigin = GameObject.Find("Character Origin").gameObject;
                GameObject gameObjectCharacterRoot = GameObject.Find("Character Root").gameObject;
                GameObject gameObjectEllieDefault = GameObject.Find("Ellie_Default").gameObject;
                GameObject gameObjectFlashLightHolder = GameObject.Find("FlashLightHolder").gameObject;
                GameObject gameObjectFlightlight = GameObject.Find("Flashlight").gameObject;
                GameObject gameObjectChild = gameObjectFlightlight.transform.GetChild(1).gameObject;
                gameObjectChild.SetActive(false);
            }

        }
        }
    }
}
