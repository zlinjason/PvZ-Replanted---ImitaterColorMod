using HarmonyLib;
using Il2CppReloaded.Gameplay;
using Il2CppSource.Controllers;

namespace ImitaterColorMod;

[HarmonyPatch(typeof(PlantController), nameof(PlantController.EnableGrayscale))]
public static class PlantController_EnableGrayscale_Patch
{
    [HarmonyPrefix]
    public static bool Prefix(PlantController __instance)
    {
        // m_plant is PlantController's back-reference to its Plant.
        // If the plant is an imitater, skip EnableGrayscale entirely.
        var plant = __instance.m_plant;
        if (plant != null && plant.mIsImitation)
            return false; // skip the original method

        return true; // allow grayscale for non-imitaters
    }
}