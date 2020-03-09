using System.Reflection;
using UnityEngine;
using TMPro;
using UMM = UnityModManagerNet.UnityModManager;
using Harmony;

namespace FontReplace
{
    static class Main
    {
        private static HarmonyInstance harmony = null;

        static bool Load(UMM.ModEntry mod)
        {
            harmony = HarmonyInstance.Create(mod.Info.Id);
            mod.OnToggle = OnToggle;
            return true;
        }

        private static bool OnToggle(UMM.ModEntry mod, bool enable) {
            if (enable) {
                harmony.PatchAll(Assembly.GetExecutingAssembly());
            } else {
                harmony.UnpatchAll();
            }
            return true;
        }

        [HarmonyPatch(typeof(TextMeshProUGUI))]
        [HarmonyPatch("LoadFontAsset")]
        private class Patch
        {
            static void Prefix(ref TMP_FontAsset ___m_fontAsset)
            {
                ___m_fontAsset = Resources.Load<TMP_FontAsset>("Fonts & Materials/LiberationSans SDF");
            }
        }
    }
}
