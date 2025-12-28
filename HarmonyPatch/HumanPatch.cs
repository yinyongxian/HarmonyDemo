using HarmonyData;
using HarmonyLib;

namespace HarmonyPatchLib
{
    [HarmonyPatch(typeof(Human))]
    [HarmonyPatch("Greet")]
    public class HumanPatch
    {
        // 方法执行前
        static void Prefix()
        {
            Console.WriteLine($"Before Greet");
        }

        // 方法执行后
        static void Postfix()
        {
            Console.WriteLine($"After Greet");
        }
    }
}
