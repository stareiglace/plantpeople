using HarmonyLib;
using Verse;

namespace Starei.NoPickyEaters
{
    [HarmonyPatch(typeof(Corpse), nameof(Corpse.IngestibleNow), MethodType.Getter)]
    public class STOP_FUCKING_EATING_THE_UNNATURAL_CORPSE
    {
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result, Corpse __instance)
        {
            if(__instance is UnnaturalCorpse)
            {
                __result = false;
                return false;
            }
            return true;
        }
    }
}