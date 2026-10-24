using HarmonyLib;
using LC2;

namespace FreeRefresh
{
    public static class RefreshPatches
    {
        [HarmonyPatch(typeof(BagSystem), "ChangeValueItem")]
        internal static class ChangeValueItem_Patch
        {
            private static bool Prefix(ItemType itemType, int addValue, bool mCallEvent, ItemLevel itemLevel)
            {
                if (addValue < 0)
                {

                    // 如果当前在背包界面，则正常减少
                    if (BagUIPatches.IsInBagUI)
                    {
                        return true; 
                    }

                    // 如果不在背包界面，拦截 虚灵硬币、魔水晶、魔铁定
                    if (itemType == ItemType.Refresh_PassiveProp) // 虚灵硬币
                    {
                        return false; 
                    }
                    // if (itemType == ItemType.Crystal) // 魔水晶
                    // {
                    //     return false; 
                    // }
                    if (itemType == ItemType.IronPowder) // 魔铁定
                    {
                        return false; 
                    }
                }
                return true;
            }
        }
    }
}