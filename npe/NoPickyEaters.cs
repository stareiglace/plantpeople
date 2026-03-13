using HarmonyLib;
using System.Reflection;
using Verse;

namespace Starei.NoPickyEaters
{
    [StaticConstructorOnStartup]
    public class NoPickyEaters : Mod
    {
        public NoPickyEaters(ModContentPack content)
        : base(content)
        {
            new Harmony("Starei.NoPickyEaters").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}