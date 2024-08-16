using ModLoader;
using UnityEngine;
using System.Collections.Generic;
using HarmonyLib;
using ModLoader.Helpers;

namespace SimpleMod
{
    [CreateAssetMenu(fileName = "SimpleModData", menuName = "Simple Mod", order = 1)]
    public class SimpleModPack : ScriptableObject
    {
        public static SimpleModPack Main;

        public const string ModFolderName = "SimpleMod";
        public const string ModIdPatching = "simplemod.danielrojas.website";   
        public MockMod Mod { get; private set; }

        public SimpleModPack()
        {
            Main = this;
        }

        public void OnEnable()
        {
            if (Application.isEditor)
            {
                return;
            }
            Debug.Log("Loading Simple Mod!");
            Mod = new MockMod(ModIdPatching, "simpleMod", "dani0105");
            Mod.ModFolder = FileLocations.BaseFolder.Extend("../Saving").Extend(ModFolderName).CreateFolder();

            KeySettings.Setup();

            SceneHelper.OnWorldSceneLoaded += this.LoadWorld;
            SceneHelper.OnWorldSceneUnloaded += this.UnloadWorld;
            SceneHelper.OnHubSceneLoaded += this.OnHub;
            SceneHelper.OnHomeSceneLoaded += this.OnHome;

            Harmony harmony = new Harmony(ModIdPatching);
            harmony.PatchAll();
            Debug.Log("Loaded!");
        }

        #region Listeners
        private void OnHome()
        {
            Debug.Log("On Home");
        }

        private void LoadWorld()
        {
            Debug.Log("On World");
        }

        private void UnloadWorld()
        {
            Debug.Log("Leave World");
        }

        private void OnHub()
        {
            Debug.Log("On Hub");
        }

        #endregion

    }
}
