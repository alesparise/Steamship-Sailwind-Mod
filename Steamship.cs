using System.Reflection;
using BepInEx;
using HarmonyLib;
//poorly written by pr0skynesis (discord username)

namespace Steamship
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Steamship : BaseUnityPlugin
    {
        // Necessary plugin info
        public const string pluginGuid = "pr0skynesis.steamship";
        public const string pluginName = "Steamship";
        public const string pluginVersion = "1.0.0";
        public const string shortName = "pr0.steamship";
        
        //config file info

        public void Awake()
        {   //Patching
            Harmony harmony = new Harmony(pluginGuid);




            harmony.Patch(original, new HarmonyMethod(patch)); //patch applied
        }
    }
}
