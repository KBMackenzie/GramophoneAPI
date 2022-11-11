using BepInEx;
using HarmonyLib;
using System.Linq;
using BepInEx.Logging;
using BepInEx.Bootstrap;
using EasyFeedback.APIs;
using System.Collections.Generic;

namespace GramophoneAPI
{
    // Plugin base:
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {   
        public const string PluginGuid = "kel.inscryption.gramophoneAPI";
        public const string PluginName = "GramophoneAPI";
        public const string PluginVersion = "1.1.0";

        internal static ManualLogSource myLogger; // Log source.
        private void Awake() {

            myLogger = Logger; // Make log source.
            Logger.LogInfo($"Loaded {PluginGuid}!");

            Harmony harmony = new Harmony("kel.harmony.gramophoneAPI");
            harmony.PatchAll();
        }
    }
}
