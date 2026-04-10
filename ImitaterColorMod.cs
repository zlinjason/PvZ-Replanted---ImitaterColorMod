using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(ImitaterColorMod.ImitaterColorMod), "Imitater Color Mod", "1.0.0", "Jason Lin")]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace ImitaterColorMod;

public class ImitaterColorMod : MelonMod
{
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("Imitater Color Mod loaded!");
    }
}