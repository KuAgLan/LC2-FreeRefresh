using HarmonyLib;
using LC2;

namespace FreeRefresh
{
    public static class BagUIPatches
    {
        internal static bool IsInBagUI = false;

        //背包界面打开
        [HarmonyPatch(typeof(PlayerBagUI), "Show")]
        internal static class PlayerBagUI_Show_Patch
        {
            private static void Postfix()
            {
                IsInBagUI = true;
            }
        }

        //背包界面关闭
        [HarmonyPatch(typeof(PlayerBagUI), "Hide")]
        internal static class PlayerBagUI_Hide_Patch
        {
            private static void Postfix()
            {
                IsInBagUI = false;
            }
        }
    }
}
