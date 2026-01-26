using HarmonyLib;

public class Patches
{
    [HarmonyPatch(typeof(scnMenu), "Start")]
    public static class scnMenu_Start_Patch
    {
        static bool Prefix(scnMenu __instance)
        {
            ModEntry.instance.ModLogger.LogInfo("scnMenu Start");
            return true;
        }
        public static void Postfix(scnMenu __instance)
        {
            ModEntry.instance.ModLogger.LogInfo("scnMenu Started");
        }
    }
}
