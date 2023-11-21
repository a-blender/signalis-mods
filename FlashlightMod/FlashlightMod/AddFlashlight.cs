using FlashlightMod;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

// ...
[assembly: MelonInfo(typeof(AddFlashlight), "My first Elster mod", "latest", "Andy Blendermann")]
[assembly: MelonGame("", "")]

namespace FlashlightMod
{
    // create a namespace for mods and a namespace for each mod. Rename class to the function of your mod
    // Example: 'AddSword', 'CombatMode'

    public class AddFlashlight : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
            GameObject gameObjectPrereq = GameObject.Find("__Prerequisites__");
            GameObject gameObjectCharacterOrigin = GameObject.Find("Character Origin").gameObject;
            GameObject gameObjectCharacterRoot = GameObject.Find("Character Root").gameObject;
            GameObject gameObjectEllieDefault = GameObject.Find("Ellie_Default").gameObject;
            GameObject gameObjectFlashLightHolder = GameObject.Find("FlashLightHolder").gameObject;
            GameObject gameObjectFlightlight = GameObject.Find("Flashlight").gameObject;
            GameObject gameObjectChild = gameObjectFlightlight.transform.GetChild(1).gameObject;
            gameObjectChild.SetActive(false);
        }

        public override void OnUpdate()
        {
            // comment out because to override the base update
            // base.OnUpdate();

            // list all game objects - FindObjectsOfType will print all active objects and child objects in the
            // current scene
            //GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            //foreach (GameObject obj in allObjects)
            //{
            //    if (SceneManager.GetActiveScene() == null)
            //    {
            //        continue;
            //    }
                // print object name to the Unity debugger console!
            //    Debug.Log("[" + obj.name + "] is an active object");
            //}

            bool keyUp = Input.GetKeyUp(KeyCode.F);

            if (keyUp)
            {
                if (!ElsterFlashLight.on)
                {
                    Cheats.forceLight = true;
                    ElsterFlashLight.on = true;
                }
                else
                {
                    ElsterFlashLight.on = false;
                }
            }

            GameObject gameObjectPrereq = GameObject.Find("__Prerequisites__");
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
