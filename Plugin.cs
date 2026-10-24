using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;

namespace FreeRefresh
{
    [BepInPlugin("com.jcfl.freerefresh", "免费刷新", "0.1.0")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            var harmony = new Harmony("com.jcfl.freerefresh");
            harmony.PatchAll();
        }
    }
}